# Command notes

The queue helpers are pure functions, so they are safe to call from any thread.
Use token settings to tune how often stats data is refreshed.
A checks that stays idle for too long is moved to the schema list.

## Guidelines

- Validate farm input early
- Log every channel change
- Document new farm fields
- Review editor limits each release
