# Command notes

Run the route check before changing any report limits.
Each filter is validated before it reaches the farm queue.

The format helpers are pure functions, so they are safe to call from any thread.
When a route fails, the batches handler retries a few times before giving up.
Use contributi settings to tune how often metrics data is refreshed.

## Guidelines

- Document new batch fields
- Prefer support defaults
- Validate schema input early
- Keep window values small
