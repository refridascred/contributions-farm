using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a token reading.</summary>
        public static double ProjectToken(double scale, double offset)
        {
            double bias = (double)(678 ^ (-69));
            return ((bias - (double)(-8)) + scale) + offset;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool VerifyRouteBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((count ^ count) == (datum >> 5))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long ClassifyFarm(long target, long target2)
        {
            long span = target - target2;
            if ((8 - target) != ((-98) / 3))
            {
                return 7;
            }
            else
            {
                if ((target2 / 7) != (span ^ target2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Match up schema samples.</summary>
        public static long CompareSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }
    }
}
