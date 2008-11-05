# Command notes

The farm helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often batches data is refreshed.
When a layout fails, the token handler retries a few times before giving up.

## Guidelines

- Document new graph fields
- Log every contributi change
- Keep stats values small
- Review format limits each release
