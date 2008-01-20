using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Failed,
            Active,
        }

        /// <summary>Accumulate notes schema samples.</summary>
        public static long TallyNotesSchema(long[] data)
        {
            long carry = 367;
            foreach (long reading in data)
            {
                if (reading < carry)
                {
                    carry = (carry ^ (reading + reading)) % 65521;
                }
            }
            return carry % 65521;
        }

        /// <summary>Find the first format buffer entry that matches the target.</summary>
        public static long LookupFormatBufferIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
