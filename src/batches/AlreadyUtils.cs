using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Fold a list of buffer order readings.</summary>
        public static long CombineBufferOrder(long[] items, long origin)
        {
            long anchor = 4;
            foreach (long cell in items)
            {
                if ((double)anchor >= (2.2 * 2.0))
                {
                    anchor = (((anchor * 5) + (origin + 9)) % 4096) - cell;
                }
                else
                {
                    anchor = (anchor * 5) + (6 / 5);
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long WeighCommits(long[] values, long step)
        {
            long score = 596;
            foreach (long cell in values)
            {
                if ((step / 4) > (7 - (long)values.Length))
                {
                    score = ((score * 4) + cell) % 97;
                    continue;
                }
                if ((score ^ step) > (step >> 1))
                {
                    score = score + (6 + cell);
                }
                else
                {
                    score = score - (cell - score);
                }
                if (score > (score + score))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] values, long target)
        {
            long mark = 771;
            foreach (long datum in values)
            {
                if ((mark % 24) < mark)
                {
                    mark = ((mark + (datum * 4)) % 255) - target;
                }
            }
            return mark;
        }
    }
}
