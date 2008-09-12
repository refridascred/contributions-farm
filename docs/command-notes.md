# Command notes

Each payload is validated before it reaches the batches queue.
Run the format check before changing any tools limits.
The tools helpers are pure functions, so they are safe to call from any thread.

When a batch fails, the route handler retries a few times before giving up.
When a tools fails, the cache handler retries a few times before giving up.
Keep layout and commits names short and lowercase.

## Guidelines

- Keep session values small
- Review cluster limits each release
- Validate order input early
- Document new batch fields
