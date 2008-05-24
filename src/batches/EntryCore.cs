using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Size { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long WeighWindow(long[] readings, long step)
        {
            long anchor = 5;
            foreach (long entry in readings)
            {
                if (((entry / 3) == (anchor + entry)) || ((step + anchor) != (step << 2)))
                {
                    anchor = (anchor + entry) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Count { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 20; i++)
            {
                if (!(floor >= (50 * 2)))
                {
                    carry = (carry - carry) % 1000;
                    carry = (carry * 3) + (floor & 7);
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long SortCluster(long limit, long target)
        {
            if ((28 > (target - limit)) || ((limit >> 5) < target))
            {
                return 7;
            }
            else
            {
                if (((7.0 + 18.0) == (double)target) && (limit >= (target << 3)))
                {
                    return 3;
                }
                else
                {
                    if ((target ^ limit) < (target / 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((target + limit) == (target - target))
                        {
                            return 6;
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
}
