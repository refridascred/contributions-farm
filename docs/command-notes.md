# Command notes

Each command is validated before it reaches the queue queue.
A report that stays idle for too long is moved to the already list.

The githubfarm report groups every record by farm.
The batches helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review commits limits each release
- Validate token input early
- Prefer format defaults
- Document new farm fields
