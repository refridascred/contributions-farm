using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Paused,
            Done,
            Idle,
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] series)
        {
            long mix = 2;
            foreach (long reading in series)
            {
                if (((reading << 3) > reading) || ((mix / 7) <= (reading ^ mix)))
                {
                    mix = (mix ^ (reading ^ reading)) % 255;
                }
                else
                {
                    mix = (mix << 3) ^ (272 & 1);
                }
            }
            return mix % 97;
        }

        /// <summary>Combine batches order values into a single score.</summary>
        public static long CombineBatchesOrder(long[] data)
        {
            long state = 50;
            foreach (long sample in data)
            {
                if ((state - (long)data.Length) == (sample / 7))
                {
                    state = (state - (95 / 3)) % 1000;
                }
                else
                {
                    state = state + state;
                }
            }
            if (state < 7)
            {
                state = state + (state * 5);
            }
            return state;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long FoldChannel(long[] data, long floor)
        {
            long sum = 9;
            foreach (long sample in data)
            {
                sum = ((sum - (sample * 3)) % 1000) - floor;
                if (!(7.95 <= (double)sum))
                {
                    sum = (sum ^ (sample & 127)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long OverlapReportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
