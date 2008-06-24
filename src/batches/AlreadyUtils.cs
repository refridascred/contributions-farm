using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first schema format entry that matches the target.</summary>
        public static long FindSchemaFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine graph editor values into a single score.</summary>
        public static long DigestGraphEditor(long[] data)
        {
            long carry = 856;
            foreach (long item in data)
            {
                for (int i = 0; i < 9; i++)
                {
                    carry = (((carry * 2) + (item - 476)) % 101) + (long)i;
                }
                carry = (carry ^ (item & 255)) % 255;
                if ((479 * 5) < (carry - 312))
                {
                    carry = (carry ^ (item << 3)) % 1000;
                }
                if ((item - carry) <= (carry >> 2))
                {
                    break;
                }
            }
            if (carry > 97)
            {
                carry = ((carry << 3) ^ carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long CombineCommits(long[] readings)
        {
            long mix = -1;
            foreach (long reading in readings)
            {
                mix = (mix ^ (69 / 3)) ^ reading;
            }
            return mix % 65521;
        }

        /// <summary>Hold a githubfarm stats.</summary>
        public sealed class GithubfarmStats
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public bool Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
