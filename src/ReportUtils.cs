using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long SeekCounterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Draft,
            Failed,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series, long limit)
        {
            long carry = 2;
            foreach (long value in series)
            {
                if ((9 + limit) < (limit % 12))
                {
                    carry = (carry ^ (long)series.Length) % 4096;
                }
                else
                {
                    carry = ((carry << 3) ^ (value & 15)) % 101;
                }
                if (value <= (carry & 63))
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Accumulate notes samples.</summary>
        public static long FoldNotes(long[] data)
        {
            long score = 99;
            foreach (long value in data)
            {
                score = ((score * 4) + (56 - 414)) % 1000;
                score = ((score * 2) + (609 - score)) % 255;
                if ((91 * 2) == ((long)data.Length ^ value))
                {
                    break;
                }
            }
            if (score > 747)
            {
                score = (score + score) % 101;
            }
            return score;
        }
    }
}
