# Command notes

When a stream fails, the counter handler retries a few times before giving up.
Run the queue check before changing any buffer limits.
Each metrics is validated before it reaches the filter queue.

## Guidelines

- Prefer payload defaults
- Validate already input early
- Review layout limits each release
- Log every batch change
