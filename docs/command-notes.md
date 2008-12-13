# Command notes

Each commits is validated before it reaches the channel queue.
When a support fails, the window handler retries a few times before giving up.

Use command settings to tune how often filter data is refreshed.
The batches helpers are pure functions, so they are safe to call from any thread.
When a schema fails, the report handler retries a few times before giving up.

## Guidelines

- Log every contributi change
- Document new checks fields
- Validate channel input early
- Keep token values small
