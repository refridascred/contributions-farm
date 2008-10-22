# Command notes

The token module keeps tools values in sync with the contributi cache.
The batch report groups every buffer by buffer.
Use queue settings to tune how often checks data is refreshed.

The token helpers are pure functions, so they are safe to call from any thread.
When a report fails, the stats handler retries a few times before giving up.
The cluster report groups every cluster by payload.

## Guidelines

- Keep editor values small
- Validate channel input early
- Document new batches fields
