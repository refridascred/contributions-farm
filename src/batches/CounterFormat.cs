using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Count counter pairs that satisfy a relation.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorBounds(long[] items, long floor)
        {
            bool valid = true;
            foreach (long entry in items)
            {
                if (entry != floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public bool Total { get; set; }
            public long Region { get; set; }
        }
    }
}
