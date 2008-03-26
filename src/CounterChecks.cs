using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Dropped,
            Closed,
            Draft,
            Active,
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Size { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long target, long step)
        {
            long edge = target ^ step;
            if (((step / 5) >= 0) || ((step - target) < (333 / 6)))
            {
                return 4;
            }
            else
            {
                if ((target << 1) == (edge - edge))
                {
                    return 7;
                }
                else
                {
                    if ((6 - edge) >= (edge + 117))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((2.8 - 5.0) >= (double)target)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string HardScore = "local-edge";
        public const long MinSize = 499;
        public const double StepLevel = 70.15;
        public const double CacheAlready = 2.09;

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long LookupBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
