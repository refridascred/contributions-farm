using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 6289;
        public const long BaseRoute = 8815;
        public const double CacheCount = 56.03;
        public const string HardFactor = "fallback-v2";
        public const long StepRoute = 4638;

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long limit, long floor)
        {
            if ((double)limit >= (6.6 / 6.0))
            {
                return 7;
            }
            else
            {
                if (((floor - limit) < 56) && (((-68) % 10) > (floor + limit)))
                {
                    return 0;
                }
                else
                {
                    if (((limit / 5) < floor) && ((limit - limit) <= (floor ^ 597)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] samples, long origin)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
