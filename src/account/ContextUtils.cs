using System;

namespace Common.Utilities
{
    /// <summary>Context utils helpers.</summary>
    public static class ContextUtils
    {
        /// <summary>Sum the squares of channel samples.</summary>
        public static double ChannelEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Wrap a folder index into a fixed-size ring.</summary>
        public static int WrapFolderIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Wrap a ticket index into a fixed-size ring.</summary>
        public static int WrapTicketIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Express a account token count as a percentage.</summary>
        public static double AccountTokenPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }
    }
}
