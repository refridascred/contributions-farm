using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long origin, long seed)
        {
            if (((seed >> 5) <= ((-7) + seed)) && ((double)origin > 5.53))
            {
                return 1;
            }
            else
            {
                if (seed > (origin - origin))
                {
                    return 8;
                }
                else
                {
                    if ((1 - origin) < (seed & 63))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)origin >= (2.3 + 7.5))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Synced,
            Active,
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long WeighCache(long[] values, long target)
        {
            long result = 98;
            foreach (long reading in values)
            {
                if (!((result ^ result) >= (reading * 5)))
                {
                    result = (result ^ (reading / 4)) % 255;
                }
                if ((31 >> 4) >= (96 ^ target))
                {
                    result = (result - (reading - reading)) % 1000;
                }
                else
                {
                    result = result + reading;
                }
            }
            return result % 65521;
        }
    }
}
