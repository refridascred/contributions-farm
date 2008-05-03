# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Use metric settings to tune how often metric data is refreshed.
Each context is validated before it reaches the batch queue.

## Guidelines

- Keep filter values small
- Log every account change
- Review farm limits each release
- Document new token fields
