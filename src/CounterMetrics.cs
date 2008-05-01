using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Match up report githubfarm samples.</summary>
        public static long CompareReportGithubfarmCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] readings, long step)
        {
            long anchor = 547;
            foreach (long datum in readings)
            {
                anchor = anchor ^ (anchor ^ datum);
                if (!((anchor + 0) > (step - 592)))
                {
                    anchor = (anchor ^ (step * 5)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (datum + (-9))) % 255;
                }
            }
            if (anchor > (-98))
            {
                anchor = (anchor ^ (9 % 10)) % 65521;
            }
            return anchor % 4096;
        }

        /// <summary>Classify a checks entry pair into a bucket.</summary>
        public static long RankChecksEntry(long target, long offset)
        {
            if (offset >= 60)
            {
                return 6;
            }
            else
            {
                if ((4.1 - 6.5) != (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Queued,
            Paused,
            Locked,
            Ready,
            Dropped,
        }
    }
}
