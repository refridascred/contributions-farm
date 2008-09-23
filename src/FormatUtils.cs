using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long SoftWidth = 1569;
        public const string HardSpan = "standard-1";
        public const long CacheWidth = 8305;

        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Synced,
            Ready,
            New,
            Locked,
            Queued,
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Token { get; set; }
            public long Weight { get; set; }
            public double Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long GradeEditor(long step, long origin)
        {
            long next = step ^ origin;
            if (((2.73 + 2.41) == (double)next) && (3.0 <= (double)step))
            {
                return 6;
            }
            else
            {
                if ((7.0 + 9.4) < (double)origin)
                {
                    return 2;
                }
                else
                {
                    if ((1 << 1) <= next)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((step % 3) != (origin / 6)) && (9.94 > (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many counter session samples are out of range.</summary>
        public static long TallyCounterSessionMatches(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) <= (seed - tally))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Check that every session record entry stays within the limit.</summary>
        public static bool VerifySessionRecordLimits(long[] readings, long target)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
