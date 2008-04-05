using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (!((item / 8) < (item << 1)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long ClassifyContext(long target, long bound)
        {
            if ((target - bound) >= (target ^ target))
            {
                return 0;
            }
            else
            {
                if (bound <= (bound >> 2))
                {
                    return 4;
                }
                else
                {
                    if (((bound >> 2) != (bound >> 5)) && (bound <= target))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((-23) <= (target * 4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long AuditCommandContributiHits(long[] readings, long step)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (3.49 > (double)seen)
                {
                    seen = ((seen + 1) - entry) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
