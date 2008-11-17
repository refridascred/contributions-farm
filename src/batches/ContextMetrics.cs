using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Synced,
            Idle,
            Paused,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelGaps(long[] series, long floor)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((95 - entry) > (floor & 1)) || ((floor + entry) <= 757))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesRange(long[] values, long step)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long IterateOrder(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                if ((result + target) > ((long)i - (long)i))
                {
                    result = (result + (result / 6)) % 65521;
                }
                result = result - (393 - target);
                if (!((result + target) >= result))
                {
                    result = ((result * 4) + (target ^ target)) % 65521;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Failed,
            Closed,
            Locked,
            Synced,
            Idle,
        }
    }
}
