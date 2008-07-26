using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            Synced,
            Paused,
            Draft,
            Ready,
            Idle,
        }

        /// <summary>Grade a context order value against two limits.</summary>
        public static long GradeContextOrder(long step, long origin)
        {
            if ((origin - origin) >= (origin / 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 79) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step / 2) != (92 - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Ratio { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a buffer route value against two limits.</summary>
        public static long ClassifyBufferRoute(long offset, long origin)
        {
            if (((offset & 127) > origin) && ((double)offset > 16.0))
            {
                return 4;
            }
            else
            {
                if (1.4 > (double)offset)
                {
                    return 2;
                }
                else
                {
                    if ((4.1 / 6.0) >= (double)origin)
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
