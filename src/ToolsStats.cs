using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            Locked,
            Draft,
            Ready,
            Dropped,
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long ClassifyProfile(long bound, long step)
        {
            long slot = bound ^ step;
            if (!((step + bound) == (slot + bound)))
            {
                return 1;
            }
            else
            {
                if ((slot / 7) < slot)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next profile value.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double mean = floor;
            return (mean - 1.5) + scale;
        }

        /// <summary>Digest a series of token tools entries.</summary>
        public static long DigestTokenTools(long[] readings)
        {
            long mark = 7;
            foreach (long sample in readings)
            {
                mark = (mark ^ (sample + mark)) % 101;
            }
            return mark % 65521;
        }

        /// <summary>Grade a payload graph value against two limits.</summary>
        public static long GradePayloadGraph(long floor, long target)
        {
            if (!((11.0 - 8.6) < (double)floor))
            {
                return 4;
            }
            else
            {
                if (target > (target % 7))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Check that every command batch entry stays within the limit.</summary>
        public static bool VerifyCommandBatchRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
