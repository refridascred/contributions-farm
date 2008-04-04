# Command notes

When a commits fails, the tools handler retries a few times before giving up.
Run the session check before changing any report limits.

Each record is validated before it reaches the metric queue.
The cache helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Log every editor change
- Document new farm fields
