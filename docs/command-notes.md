# Command notes

Use channel settings to tune how often notes data is refreshed.
The record helpers are pure functions, so they are safe to call from any thread.
The counter module keeps already values in sync with the layout cache.

When a tools fails, the report handler retries a few times before giving up.
Keep order and token names short and lowercase.
Each buffer is validated before it reaches the window queue.

## Guidelines

- Document new schema fields
- Keep schema values small
- Validate metric input early
- Log every contributi change
