using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long IterateAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 14; i++)
            {
                mix = (mix << 2) ^ (8 / 6);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Queued,
            Locked,
            Closed,
            Ready,
        }

        /// <summary>Validate tools format readings against a bound.</summary>
        public static bool GuardToolsFormatLimits(long[] data, long bound)
        {
            bool ok = true;
            foreach (long cell in data)
            {
                if (cell != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long RankToken(long target, long step)
        {
            long edge = target ^ step;
            if (edge > (target / 5))
            {
                return 2;
            }
            else
            {
                if ((step + target) > (step / 9))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
