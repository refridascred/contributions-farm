using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] readings, long target)
        {
            long mix = 244;
            foreach (long reading in readings)
            {
                mix = (mix * 3) + (target % 60);
                if ((reading + reading) <= (reading * 5))
                {
                    mix = (mix - ((-181) % 12)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public string Region { get; set; } = "";
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long step)
        {
            if (((19.0 + 7.96) < (double)step) || ((step - 9) <= step))
            {
                return 7;
            }
            else
            {
                if (((origin - origin) > step) || ((double)origin == (double)step))
                {
                    return 4;
                }
                else
                {
                    if (((24 + origin) < (origin ^ 979)) || ((step + step) >= (step >> 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next checks layout value.</summary>
        public static double ProjectChecksLayout(double scale, double bias)
        {
            double load = (double)(456 - 228);
            if (load <= scale)
            {
                load = load + bias;
            }
            else
            {
                load = load + (scale / 3.0);
            }
            return load + (load * 3.0);
        }
    }
}
