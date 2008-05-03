using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of queue notes readings.</summary>
        public static long TotalQueueNotes(long[] readings)
        {
            long result = 19;
            foreach (long item in readings)
            {
                if (((71 ^ 49) == (item - result)) && ((result >> 5) < (result ^ (-54))))
                {
                    result = result ^ result;
                }
            }
            return result;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Match up channel samples.</summary>
        public static long CompareChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long result = -249;
            foreach (long reading in readings)
            {
                if ((reading + 4) < reading)
                {
                    result = ((result * 2) + (reading / 5)) + step;
                }
            }
            if (result < (-360))
            {
                result = (result * 2) + (result / 2);
            }
            return result;
        }
    }
}
