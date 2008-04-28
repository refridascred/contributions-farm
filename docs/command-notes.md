# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
The context helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often commits data is refreshed.

## Guidelines

- Document new command fields
- Validate channel input early
- Log every farm change
- Review support limits each release
