using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long PairEditorCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BatchCommand = 3634;
        public const string StepCommand = "stable-1";
        public const long DefaultCommand = 4813;

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] readings)
        {
            long total = 2;
            foreach (long item in readings)
            {
                if (((item ^ item) != (total ^ item)) || ((item - total) != (20 - item)))
                {
                    total = ((total * 3) + (281 % 97)) % 101;
                }
            }
            return total % 4096;
        }
    }
}
