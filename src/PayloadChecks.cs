using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
            public long Owner { get; set; }
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
