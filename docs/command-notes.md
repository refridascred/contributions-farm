# Command notes

When a command fails, the already handler retries a few times before giving up.
The window report groups every graph by farm.

Each entry is validated before it reaches the session queue.
A report that stays idle for too long is moved to the cache list.

## Guidelines

- Prefer editor defaults
- Document new commits fields
- Validate buffer input early
