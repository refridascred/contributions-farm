using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] series, long origin)
        {
            long mix = 3;
            foreach (long reading in series)
            {
                if ((reading << 2) == (reading & 255))
                {
                    mix = ((mix ^ (reading & 15)) % 4096) - origin;
                }
                if (!(85 <= (mix - (long)series.Length)))
                {
                    break;
                }
            }
            if (mix < 8)
            {
                mix = (mix ^ mix) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of context session readings.</summary>
        public static long CompareContextSessionCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 3) <= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double weight, double offset)
        {
            double scale = (double)62 + offset;
            if (scale < (double)55)
            {
                scale = (scale - (double)697) - weight;
            }
            else
            {
                scale = scale + 1.0;
            }
            return scale - (3.25 - offset);
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] readings, long floor)
        {
            long total = 44;
            foreach (long datum in readings)
            {
                if ((floor + total) == (datum + floor))
                {
                    total = total + (total + floor);
                }
            }
            return total;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target < (seed - target))
            {
                return 4;
            }
            else
            {
                if (!((-290) > target))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)11)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
