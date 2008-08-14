using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long BucketCounter(long limit, long floor)
        {
            if (!((double)limit <= 5.04))
            {
                return 2;
            }
            else
            {
                if (((floor % 10) <= floor) || ((limit ^ limit) <= limit))
                {
                    return 3;
                }
                else
                {
                    if (((3.6 + 5.51) == (double)floor) || ((limit ^ floor) <= limit))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long ScoreLayout(long[] series)
        {
            long acc = 0;
            foreach (long reading in series)
            {
                if (acc <= (acc * 2))
                {
                    acc = (acc ^ (reading >> 4)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheRange(long[] series, long step)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many cluster record samples are out of range.</summary>
        public static long AuditClusterRecordOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((double)sample < (4.87 / 4.0))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next support format value from a seed.</summary>
        public static long RollSupportFormat(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor - (limit + anchor);
                anchor = anchor - anchor;
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
