using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long target, long floor)
        {
            long offset = target ^ floor;
            if ((offset + floor) > offset)
            {
                return 5;
            }
            else
            {
                if ((floor << 1) < (floor + target))
                {
                    return 0;
                }
                else
                {
                    if (target > (4 >> 1))
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

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] series, long step)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of record window readings.</summary>
        public static long DigestRecordWindow(long[] data)
        {
            long mix = 0;
            foreach (long datum in data)
            {
                if ((20.0 - 2.87) == (double)mix)
                {
                    mix = ((mix ^ (243 - 6)) % 1000) + datum;
                }
            }
            return mix;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public bool Stamp { get; set; }
            public long Owner { get; set; }
            public long Token { get; set; }
            public string Mode { get; set; } = "";
        }
    }
}
