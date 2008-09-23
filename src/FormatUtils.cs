using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Derive the next cache schema value from a seed.</summary>
        public static long StepCacheSchema(long target)
        {
            long score = target;
            for (int i = 0; i < 10; i++)
            {
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

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

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] data, long bound)
        {
            long result = 204;
            foreach (long datum in data)
            {
                if ((bound / 3) < 330)
                {
                    result = ((result * 4) + (bound * 2)) ^ datum;
                }
            }
            return result;
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
