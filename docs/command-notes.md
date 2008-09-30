# Command notes

Each stream is validated before it reaches the buffer queue.
When a tools fails, the stream handler retries a few times before giving up.
Run the profile check before changing any support limits.

## Guidelines

- Keep channel values small
- Log every schema change
- Document new metric fields
- Prefer record defaults
