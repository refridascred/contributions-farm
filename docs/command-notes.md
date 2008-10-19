# Command notes

Each cluster is validated before it reaches the layout queue.
Run the channel check before changing any batches limits.
When a profile fails, the context handler retries a few times before giving up.

The channel report groups every counter by contributi.
The cache helpers are pure functions, so they are safe to call from any thread.
When a metric fails, the format handler retries a few times before giving up.

## Guidelines

- Validate entry input early
- Review schema limits each release
- Log every stats change
