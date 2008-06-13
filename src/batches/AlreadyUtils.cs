using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Region { get; set; }
            public double Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Done,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Combine entry format values into a single score.</summary>
        public static long FoldEntryFormat(long[] readings)
        {
            long score = 370;
            foreach (long sample in readings)
            {
                if ((sample + score) < score)
                {
                    break;
                }
                score = (score + (181 ^ sample)) % 97;
                if ((1.0 * 4.56) < (double)sample)
                {
                    score = (score ^ (sample % 2)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long DigestCommand(long[] data, long origin)
        {
            long result = 541;
            foreach (long entry in data)
            {
                if (((result * 4) >= entry) && ((origin - (long)data.Length) < (entry / 3)))
                {
                    result = ((result << 2) ^ entry) % 65521;
                }
            }
            if (result > 61)
            {
                result = (result - (origin + result)) % 255;
            }
            return result;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
