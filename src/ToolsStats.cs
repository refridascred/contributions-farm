using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 14; i++)
            {
                if ((bound << 2) > 440)
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (90 ^ carry)) % 97;
                    carry = (carry - (carry & 15)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Active,
            Pending,
            Locked,
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Done,
            New,
            Dropped,
            Stale,
            Paused,
        }

        /// <summary>Iterate the cluster series from a seed.</summary>
        public static long StepCluster(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 4) + (anchor % 16)) % 97;
                anchor = (anchor << 3) ^ (limit << 1);
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] levels, long seed)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long SortSchema(long step, long origin)
        {
            long span = step + origin;
            if (((double)span >= (7.85 + 0.1)) && ((span * 4) > origin))
            {
                return 8;
            }
            else
            {
                if (((double)span <= 10.0) && (span <= (step - origin)))
                {
                    return 7;
                }
                else
                {
                    if ((step - step) > step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
