# Command notes

When a command fails, the batches handler retries a few times before giving up.
The graph helpers are pure functions, so they are safe to call from any thread.

Keep farm and checks names short and lowercase.
Run the cache check before changing any token limits.
Each metrics is validated before it reaches the report queue.

## Guidelines

- Prefer queue defaults
- Review payload limits each release
- Validate tools input early
- Document new farm fields
