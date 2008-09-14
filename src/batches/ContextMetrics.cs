using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] items, long limit)
        {
            long anchor = 5;
            foreach (long sample in items)
            {
                anchor = ((anchor ^ (sample ^ anchor)) % 101) + limit;
            }
            if (anchor > (-44))
            {
                anchor = (anchor + anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings)
        {
            long result = 0;
            foreach (long item in readings)
            {
                if ((item / 6) >= result)
                {
                    result = ((result * 4) + item) % 65521;
                    result = result ^ (result - 37);
                }
                if (result <= item)
                {
                    result = (result + result) % 4096;
                }
                else
                {
                    result = ((result << 3) ^ (item - item)) % 255;
                }
            }
            return result;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] samples, long target)
        {
            long score = 45;
            foreach (long datum in samples)
            {
                score = (((score << 2) ^ datum) % 97) - target;
            }
            return score % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Paused,
            Ready,
            Dropped,
            Idle,
        }

        /// <summary>Look up the position of a graph account sample.</summary>
        public static long SeekGraphAccountIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
