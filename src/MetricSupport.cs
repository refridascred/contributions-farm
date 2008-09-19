using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long LocateCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter batch readings.</summary>
        public static long ScoreCounterBatch(long[] samples, long target)
        {
            long state = 4;
            foreach (long reading in samples)
            {
                if (!(state <= reading))
                {
                    state = (state - (state + state)) + target;
                }
                state = state ^ (reading >> 1);
            }
            if (state > 6)
            {
                state = ((state << 2) ^ (state >> 1)) % 1000;
            }
            return state;
        }
    }
}
