# Command notes

Use checks settings to tune how often support data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
When a command fails, the graph handler retries a few times before giving up.

## Guidelines

- Log every format change
- Validate cache input early
- Document new batches fields
