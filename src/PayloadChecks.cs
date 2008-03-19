using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadRange(long[] items, long step)
        {
            bool ready = true;
            foreach (long cell in items)
            {
                if (cell < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardCount = 7503;
        public const double WindowSize = 40.27;
        public const long IdleProfile = 7433;

        /// <summary>Locate a batch reading by value.</summary>
        public static long LookupBatchIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks order reading.</summary>
        public static double ProjectChecksOrder(double bias, double offset)
        {
            double drift = offset;
            if (drift <= (offset * 1.44))
            {
                drift = drift - (9.0 + bias);
            }
            return drift + (drift * 9.81);
        }

        /// <summary>Look up the position of a account order sample.</summary>
        public static long FindAccountOrderIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                mark = (mark - (mark >> 4)) % 65521;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
