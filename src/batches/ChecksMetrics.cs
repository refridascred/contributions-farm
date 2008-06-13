using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 8; i++)
            {
                if (((long)i - offset) >= ((long)i << 1))
                {
                    mix = (mix + (133 % 12)) % 97;
                    break;
                }
                mix = mix ^ (mix - offset);
                if ((mix * 4) != ((long)i + (long)i))
                {
                    mix = (mix << 2) ^ (offset - (long)i);
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Stale,
            Pending,
            Done,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Failed,
            Stale,
            Ready,
            Dropped,
        }

        /// <summary>Digest a series of tools graph entries.</summary>
        public static long DigestToolsGraph(long[] values)
        {
            long state = 645;
            foreach (long sample in values)
            {
                state = ((state << 3) ^ (sample & 15)) % 1000;
            }
            if (state > 32)
            {
                state = (state + state) % 255;
            }
            return state % 97;
        }
    }
}
