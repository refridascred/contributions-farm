using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate profile samples.</summary>
        public static long CombineProfile(long[] data)
        {
            long carry = 10;
            foreach (long entry in data)
            {
                carry = (carry - (entry - entry)) % 255;
            }
            if (carry > 51)
            {
                carry = (carry * 5) + carry;
            }
            return carry;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long MeasureChannelHits(long[] data, long origin)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((origin >> 5) <= reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of graph format entries.</summary>
        public static long DigestGraphFormat(long[] levels)
        {
            long total = 5;
            foreach (long datum in levels)
            {
                total = ((total + (total ^ 91)) % 65521) + datum;
            }
            return total;
        }

        /// <summary>Accumulate farm payload samples.</summary>
        public static long TotalFarmPayload(long[] series)
        {
            long mix = 85;
            foreach (long reading in series)
            {
                if ((mix - reading) <= (reading ^ mix))
                {
                    mix = ((mix << 3) ^ (reading >> 5)) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long WindowContext = 5659;
        public const string SoftContext = "standard-1";
        public const long BurstBudget = 5117;
        public const long BaseContext = 6501;
        public const long BurstContext = 3725;

        /// <summary>Look up the position of a githubfarm order sample.</summary>
        public static long SeekGithubfarmOrderIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > seed) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
