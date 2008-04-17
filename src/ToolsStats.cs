using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Pending,
            Done,
            Paused,
        }

        /// <summary>Accumulate already queue samples.</summary>
        public static long DigestAlreadyQueue(long[] items)
        {
            long mix = 7;
            foreach (long entry in items)
            {
                if (entry < (entry + 7))
                {
                    mix = (mix * 2) + (entry + (long)items.Length);
                }
            }
            return mix % 1000;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long anchor = 3;
            foreach (long reading in levels)
            {
                anchor = ((anchor << 2) ^ (reading % 100)) % 101;
                if (anchor <= (anchor / 6))
                {
                    anchor = (anchor + anchor) % 101;
                }
                if ((double)reading > (1.1 - 9.92))
                {
                    break;
                }
            }
            if (anchor > 856)
            {
                anchor = (anchor - (anchor & 127)) % 255;
            }
            return anchor % 97;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long HardTimeout = 618;
        public const string IdleCommand = "cached-v2";
        public const long StepCommand = 1288;
        public const string HardCommand = "local-edge";
        public const long BurstRatio = 407;

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if (!(hits > (sample + 50)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
