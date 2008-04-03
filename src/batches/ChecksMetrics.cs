using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count the buffer graph entries that pass the check.</summary>
        public static long CountBufferGraphOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if ((6.24 - 9.8) >= (double)entry)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Closed,
            Draft,
            Paused,
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Ready,
            Draft,
            Locked,
            Stale,
        }

        /// <summary>Combine batches layout values into a single score.</summary>
        public static long TallyBatchesLayout(long[] samples)
        {
            long carry = 950;
            foreach (long reading in samples)
            {
                carry = (carry + reading) % 255;
                if ((reading <= (carry + carry)) && (carry > ((-2) % 10)))
                {
                    carry = ((carry * 4) + (6 << 2)) % 97;
                }
                else
                {
                    carry = carry + (carry & 7);
                }
                if ((reading - reading) != (reading + 719))
                {
                    break;
                }
            }
            if (carry > 35)
            {
                carry = (carry + (6 ^ carry)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long GradeLayout(long bound, long step)
        {
            long bound2 = bound ^ step;
            if ((double)bound != (double)step)
            {
                return 2;
            }
            else
            {
                if (((bound2 << 2) >= (bound2 ^ bound2)) || ((step / 2) > 5))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
