# Command notes

Each record is validated before it reaches the record queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep batch values small
- Review stream limits each release
- Document new batch fields
- Prefer commits defaults
