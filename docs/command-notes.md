# Command notes

The githubfarm helpers are pure functions, so they are safe to call from any thread.
The cluster helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate filter input early
- Keep record values small
- Document new farm fields
