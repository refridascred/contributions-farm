using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Classify a commits stats pair into a bucket.</summary>
        public static long SortCommitsStats(long limit, long target)
        {
            long bound = limit ^ target;
            if ((limit < bound) && ((bound + target) < 13))
            {
                return 2;
            }
            else
            {
                if (bound > 92)
                {
                    return 6;
                }
                else
                {
                    if ((bound + bound) >= (limit << 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine order batch values into a single score.</summary>
        public static long DigestOrderBatch(long[] values, long origin)
        {
            long total = -10;
            foreach (long value in values)
            {
                total = (total ^ (value * 2)) - origin;
                total = (total - total) % 65521;
                if (((total ^ value) != (total & 63)) || (((long)values.Length % 7) == (total + total)))
                {
                    total = (total - ((-4) % 7)) % 255;
                }
            }
            return total % 65521;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsMatches(long[] items, long offset)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((((offset * 5) >= 3) && ((value & 15) == (value % 5))) || !(value <= (tally % 5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (3.2 - 4.9))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((double)bound >= (18.0 / 6.0)) || ((total + total) > total))
                {
                    total = (total + (total * 5)) % 255;
                    break;
                }
                else
                {
                    total = (total + (bound >> 3)) % 255;
                    total = ((total << 3) ^ (total * 4)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
