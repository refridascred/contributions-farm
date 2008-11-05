using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long ScoreContributi(long[] readings)
        {
            long sum = 7;
            foreach (long datum in readings)
            {
                if (((datum / 3) <= (datum + sum)) || ((sum / 8) != (sum / 5)))
                {
                    sum = (sum - (sum + 8)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] == seed) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the buffer layout entries that pass the check.</summary>
        public static long MeasureBufferLayoutMatches(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits & 127) != ((long)readings.Length << 2)) || !(datum <= (505 * 5)))
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Rank order editor input into a small class.</summary>
        public static long SortOrderEditor(long floor, long step)
        {
            long offset = floor - step;
            if ((step + offset) <= (42 + floor))
            {
                return 2;
            }
            else
            {
                if (step <= (offset << 3))
                {
                    return 5;
                }
                else
                {
                    if ((floor * 5) <= floor)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step + floor) < (offset * 4))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool ValidateContributiRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long reading in data)
            {
                if (reading > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
