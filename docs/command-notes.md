# Command notes

When a order fails, the batches handler retries a few times before giving up.
The report report groups every context by order.
The filter report groups every profile by filter.

Each record is validated before it reaches the cache queue.
The batches report groups every editor by channel.

## Guidelines

- Document new schema fields
- Log every entry change
- Validate editor input early
