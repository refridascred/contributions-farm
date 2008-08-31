# Command notes

Each batches is validated before it reaches the notes queue.
Use channel settings to tune how often profile data is refreshed.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new report fields
- Validate batches input early
- Review contributi limits each release
- Log every farm change
