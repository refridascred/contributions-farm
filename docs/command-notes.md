# Command notes

Each order is validated before it reaches the command queue.
The cache module keeps commits values in sync with the editor cache.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate notes input early
- Document new record fields
- Prefer layout defaults
- Review stats limits each release
