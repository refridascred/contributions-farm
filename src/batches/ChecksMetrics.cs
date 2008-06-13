using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long CountProfileMatches(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((reading % 5) <= reading)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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

        /// <summary>Fold a list of tools readings.</summary>
        public static long ScoreTools(long[] readings)
        {
            long mark = 4;
            foreach (long cell in readings)
            {
                if ((cell - 55) == (mark >> 3))
                {
                    mark = mark - (mark + 7);
                }
                if ((cell < (cell >> 3)) && ((cell / 5) < mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
