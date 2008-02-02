using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long CombineSession(long[] samples, long target)
        {
            long score = 6;
            foreach (long entry in samples)
            {
                if (2.2 >= (double)score)
                {
                    score = ((score - 5) % 65521) - target;
                }
                else
                {
                    score = (score - (74 + entry)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long RollCluster(long bound)
        {
            long score = bound;
            for (int i = 0; i < 17; i++)
            {
                double drift = 2.7;
                if (drift > (drift - drift))
                {
                    drift = drift + drift;
                }
                else
                {
                    drift = drift - (drift * 6.54);
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool VerifySchemaRange(long[] series, long limit)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferGaps(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((bound - hits) >= (entry + 96))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry != target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of checks filter readings.</summary>
        public static long TotalChecksFilter(long[] series, long step)
        {
            long mix = 30;
            foreach (long datum in series)
            {
                mix = ((mix << 3) ^ (datum * 3)) % 97;
            }
            if (mix > (-5))
            {
                mix = (mix - (step << 1)) % 101;
            }
            return mix;
        }
    }
}
