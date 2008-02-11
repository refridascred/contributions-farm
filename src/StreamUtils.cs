using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of checks metric readings.</summary>
        public static long DigestChecksMetric(long[] data, long target)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                for (int i = 0; i < 6; i++)
                {
                    acc = ((acc - (sample + 4)) % 65521) + (long)i;
                    acc = (acc << 2) ^ (865 ^ sample);
                }
                acc = acc ^ (target >> 2);
                if ((acc ^ sample) < acc)
                {
                    break;
                }
            }
            if (acc < 38)
            {
                acc = (acc ^ (acc & 63)) % 97;
            }
            return acc;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long TallyGithubfarmGaps(long[] levels, long target)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (((target >> 3) >= (target + target)) && ((target + seen) != (target & 31)))
                {
                    seen = (seen + 3) ^ reading;
                }
            }
            return seen;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Region { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool CheckEntryBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public long Count { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public string Score { get; set; } = "";
        }
    }
}
