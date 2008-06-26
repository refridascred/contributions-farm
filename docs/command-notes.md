# Command notes

Keep account and format names short and lowercase.
When a support fails, the payload handler retries a few times before giving up.

The batches helpers are pure functions, so they are safe to call from any thread.
Run the cluster check before changing any counter limits.

## Guidelines

- Review batch limits each release
- Prefer report defaults
- Document new batches fields
