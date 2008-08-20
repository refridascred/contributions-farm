using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Idle,
            Stale,
            Done,
            Queued,
            Draft,
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Stale,
            Queued,
            Idle,
            Synced,
            Ready,
        }

        /// <summary>Check that every tools stats entry stays within the limit.</summary>
        public static bool GuardToolsStatsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double rate, double bias)
        {
            double weight = (double)((-137) - 7);
            if (weight > (weight / 4.0))
            {
                weight = (weight - (double)50) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - 19.0) + (double)(long)i;
            }
            return weight + rate;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long BucketContributi(long origin, long limit)
        {
            long lane = origin - limit;
            if (((origin >> 5) > (3 + 504)) && (25 >= (lane << 1)))
            {
                return 8;
            }
            else
            {
                if ((limit % 7) == (417 + (-958)))
                {
                    return 1;
                }
                else
                {
                    if ((lane + lane) < origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((limit > (32 % 16)) || (limit > (origin / 2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
