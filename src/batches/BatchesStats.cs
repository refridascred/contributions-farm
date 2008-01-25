using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowNotes = 9483;
        public const string DefaultNotes = "local-edge";
        public const double IdleFactor = 93.16;

        /// <summary>Classify a tools profile pair into a bucket.</summary>
        public static long GradeToolsProfile(long origin, long seed)
        {
            if (!((origin * 5) > (seed / 2)))
            {
                return 8;
            }
            else
            {
                if ((seed - 6) <= (seed % 100))
                {
                    return 7;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Mode { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
