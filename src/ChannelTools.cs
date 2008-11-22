using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next record queue value from a seed.</summary>
        public static long IterateRecordQueue(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 6; i++)
            {
                if (((4 % 100) != (sum & 63)) || ((double)floor <= (4.37 + 20.0)))
                {
                    sum = sum + (floor - floor);
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 9698;
        public const double WindowInterval = 57.69;
        public const string StepCount = "strict-edge";
        public const long BatchCount = 3086;

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public long Region { get; set; }
            public double Owner { get; set; }
        }
    }
}
