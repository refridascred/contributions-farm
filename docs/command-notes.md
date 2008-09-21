# Command notes

Each filter is validated before it reaches the cluster queue.
Keep editor and counter names short and lowercase.

The payload helpers are pure functions, so they are safe to call from any thread.
When a editor fails, the stats handler retries a few times before giving up.

## Guidelines

- Review checks limits each release
- Document new payload fields
- Validate format input early
- Prefer context defaults
