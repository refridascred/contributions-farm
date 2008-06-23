using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long GradeWindow(long step, long origin)
        {
            if ((origin % 7) <= (step & 255))
            {
                return 0;
            }
            else
            {
                if ((origin >> 2) >= origin)
                {
                    return 4;
                }
                else
                {
                    if (step <= (583 & 63))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((double)origin <= (7.4 / 7.0)) && ((double)step < 7.21))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Paused,
            Ready,
            Done,
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public bool Owner { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
