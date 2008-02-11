using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Roll a editor already counter forward.</summary>
        public static long IterateEditorAlready(long step)
        {
            long carry = step;
            for (int i = 0; i < 14; i++)
            {
                if (((step + 5) < 99) && ((step * 3) > (carry & 1)))
                {
                    continue;
                }
                carry = carry - step;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    carry = ((carry * 2) + step) + (long)i2;
                    carry = ((carry << 2) ^ (0 << 3)) % 101;
                }
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Weight { get; set; }
            public double Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Derive the next checks farm value from a seed.</summary>
        public static long DeriveChecksFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 5; i++)
            {
                if (((target - state) < target) || ((0.28 - 0.4) != (double)target))
                {
                    state = ((state << 3) ^ (4 & 255)) % 4096;
                }
                state = ((state << 3) ^ state) % 1000;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (matches <= (datum + matches))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
