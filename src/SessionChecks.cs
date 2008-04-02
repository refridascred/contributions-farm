using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] values)
        {
            long result = 376;
            foreach (long datum in values)
            {
                if ((datum + result) == (datum + 36))
                {
                    result = (result ^ (result + result)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderHits(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((matches + matches) == (cell + matches))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Ready,
            Done,
            Dropped,
            Locked,
        }
    }
}
