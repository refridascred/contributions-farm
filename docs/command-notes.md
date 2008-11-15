# Command notes

The layout report groups every entry by format.
The tools helpers are pure functions, so they are safe to call from any thread.
Run the filter check before changing any batches limits.

A tools that stays idle for too long is moved to the payload list.
Use metrics settings to tune how often tools data is refreshed.

## Guidelines

- Document new commits fields
- Review window limits each release
- Log every farm change
- Prefer schema defaults
