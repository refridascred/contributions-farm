using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double SmoothCommand(double bias, double offset)
        {
            double load = (offset * 2.5) - bias;
            for (int i = 0; i < 8; i++)
            {
                load = (load - (8.37 - bias)) - (double)(long)i;
            }
            return load + offset;
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Count { get; set; }
            public long Level { get; set; }
            public double Stamp { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 7787;
        public const double StepLevel = 26.02;
        public const long BaseRatio = 1834;

        /// <summary>Look up the position of a entry sample.</summary>
        public static long LocateEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
