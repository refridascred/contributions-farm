# Command notes

Run the report check before changing any account limits.
The format report groups every support by batches.

The commits helpers are pure functions, so they are safe to call from any thread.
When a stats fails, the queue handler retries a few times before giving up.
The metrics module keeps record values in sync with the schema cache.

## Guidelines

- Validate tools input early
- Document new farm fields
- Keep payload values small
- Prefer queue defaults
