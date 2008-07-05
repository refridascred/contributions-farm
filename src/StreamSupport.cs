using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Validate token queue readings against a bound.</summary>
        public static bool VerifyTokenQueueRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsOutliers(long[] series, long step)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (reading > 967)
                {
                    tally = (tally + 2) + step;
                }
            }
            return tally;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long FindEditorIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
