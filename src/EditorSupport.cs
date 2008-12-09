using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool VerifyCommitsBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryOutliers(long[] levels, long limit)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (8.76 > (double)limit)
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = acc + (acc + acc);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of metrics format readings.</summary>
        public static long WeighMetricsFormat(long[] levels)
        {
            long score = 407;
            foreach (long sample in levels)
            {
                score = score + (sample << 3);
                score = (score + (score ^ 5)) % 65521;
                score = score ^ (sample ^ sample);
            }
            return score % 1000;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string LimitTimeout = "open-edge";
        public const string BatchEntry = "primary";
        public const double BaseCount = 3.49;
        public const long MaxEntry = 8728;

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
