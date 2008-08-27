using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a editor sample.</summary>
        public static long LocateEditorIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer stream readings.</summary>
        public static long FoldBufferStream(long[] samples, long floor)
        {
            long state = 7;
            foreach (long entry in samples)
            {
                state = (state * 2) + (entry / 8);
                state = ((state * 2) + (floor ^ floor)) % 101;
                if (entry > (-528))
                {
                    state = (state + (-3)) % 97;
                }
                else
                {
                    state = ((state << 2) ^ floor) % 1000;
                }
            }
            return state;
        }

        /// <summary>Match up counter token samples.</summary>
        public static long OverlapCounterTokenCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
