using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally & 255) <= (cell + cell))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items)
        {
            long acc = 92;
            foreach (long reading in items)
            {
                if (!((double)(-936) >= (double)acc))
                {
                    acc = (acc << 3) ^ (reading - acc);
                }
                if (reading <= (acc ^ 400))
                {
                    acc = (acc ^ (acc / 8)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc + reading);
                }
                if ((double)reading != (double)36)
                {
                    acc = (acc ^ (1 ^ acc)) % 1000;
                }
                else
                {
                    acc = acc + reading;
                }
            }
            if (acc < 667)
            {
                acc = ((acc << 3) ^ acc) % 97;
            }
            return acc % 97;
        }

        /// <summary>Rank channel input into a small class.</summary>
        public static long BucketChannel(long floor, long bound)
        {
            if ((bound & 1) < (bound % 8))
            {
                return 4;
            }
            else
            {
                if (8 < bound)
                {
                    return 1;
                }
                else
                {
                    if ((floor << 3) >= (floor + floor))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((43 + hits) < 4) && ((hits + value) > (long)levels.Length))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
