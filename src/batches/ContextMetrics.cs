using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyOutliers(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell - origin) <= seen)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public string Region { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Iterate the checks buffer series from a seed.</summary>
        public static long StepChecksBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 20; i++)
            {
                if (((long)i < (step >> 3)) && ((double)(long)i == (1.3 * 7.76)))
                {
                    mark = (mark - (step - 702)) % 101;
                }
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long LocateGithubfarmIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < origin) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Dropped,
            Idle,
            Synced,
            Locked,
            Ready,
        }
    }
}
