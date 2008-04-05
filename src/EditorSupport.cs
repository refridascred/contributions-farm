using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Look up the position of a schema layout sample.</summary>
        public static long FindSchemaLayoutIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream window entry stays within the limit.</summary>
        public static bool VerifyStreamWindowLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool CheckFarmRange(long[] data, long target)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double SoftFormat = 27.22;
        public const long MinFormat = 6093;
        public const long WindowFormat = 610;
        public const double DefaultFormat = 78.78;
        public const double StepWidth = 47.95;

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double ratio, double span)
        {
            double load = (double)785 - (ratio * 9.0);
            for (int i = 0; i < 5; i++)
            {
                load = ((load + load) + (double)(long)i) + span;
            }
            return load + load;
        }
    }
}
