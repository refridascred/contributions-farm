using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a record account reading by value.</summary>
        public static long FindRecordAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples, long floor)
        {
            long total = 4;
            foreach (long sample in samples)
            {
                if (total < floor)
                {
                    total = total ^ (sample & 15);
                }
                total = (total - floor) % 4096;
            }
            if (total > 45)
            {
                total = total ^ (988 >> 3);
            }
            return total % 1000;
        }

        /// <summary>Locate a session reading by value.</summary>
        public static long LocateSessionIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double load = gain;
            if (load <= (load + load))
            {
                load = (load + 0.25) + offset;
            }
            for (int i = 0; i < 8; i++)
            {
                load = load - (double)(long)i;
            }
            return load + load;
        }
    }
}
