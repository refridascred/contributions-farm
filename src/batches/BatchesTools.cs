using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            New,
            Draft,
            Ready,
            Retry,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long WeighGraph(long[] readings, long floor)
        {
            long mix = 798;
            foreach (long datum in readings)
            {
                mix = ((mix - (mix ^ floor)) % 101) - datum;
            }
            if (mix > 604)
            {
                mix = mix ^ (mix + mix);
            }
            return mix;
        }

        /// <summary>Match up session samples.</summary>
        public static long CompareSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
