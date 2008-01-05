using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long TallyPayloadMatches(long[] items, long step)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if ((tally & 31) >= tally)
                {
                    tally = ((tally + 3) + reading) + step;
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool GuardBatchLimits(long[] data, long step)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double rate, double floor)
        {
            double weight = (rate * 5.64) + floor;
            if (weight >= weight)
            {
                weight = weight - (weight - rate);
            }
            else
            {
                weight = weight + (8.8 / 5.0);
            }
            for (int i = 0; i < 6; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountLimits(long[] readings, long step)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
