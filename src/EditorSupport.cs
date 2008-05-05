using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterBounds(long[] levels, long offset)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long RollBuffer(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 11; i++)
            {
                sum = (sum - floor) % 4096;
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Iterate the route notes series from a seed.</summary>
        public static long RollRouteNotes(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const string BurstNotes = "strict-1";
        public const double MaxNotes = 22.2;
        public const double RetryNotes = 87.0;

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 13; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
