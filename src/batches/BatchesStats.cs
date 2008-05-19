using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool VerifyProfileRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 4; i++)
            {
                anchor = (anchor ^ (floor + (long)i)) % 97;
                anchor = (anchor + (floor + (-2))) % 1000;
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Count { get; set; }
            public bool Level { get; set; }
            public long Size { get; set; }
        }
    }
}
