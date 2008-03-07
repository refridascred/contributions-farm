# Command notes

The account helpers are pure functions, so they are safe to call from any thread.
A filter that stays idle for too long is moved to the format list.

## Guidelines

- Log every layout change
- Validate stream input early
- Document new command fields
- Review record limits each release
