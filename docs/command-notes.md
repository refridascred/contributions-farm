# Command notes

Run the queue check before changing any contributi limits.
A support that stays idle for too long is moved to the metric list.
Run the tools check before changing any tools limits.

When a stream fails, the stats handler retries a few times before giving up.
Run the stream check before changing any checks limits.

## Guidelines

- Review profile limits each release
- Log every counter change
- Validate record input early
- Prefer farm defaults
