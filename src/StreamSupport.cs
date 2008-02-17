using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the contributi channel series from a seed.</summary>
        public static long RollContributiChannel(long step)
        {
            long mix = step;
            for (int i = 0; i < 8; i++)
            {
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] values)
        {
            long result = 282;
            foreach (long entry in values)
            {
                if ((result - entry) <= 35)
                {
                    result = (result ^ (entry + result)) % 255;
                }
                else
                {
                    result = (result * 5) + entry;
                }
            }
            if (result < 40)
            {
                result = result + (-9);
            }
            return result;
        }

        /// <summary>Match up profile samples.</summary>
        public static long CompareProfileCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
