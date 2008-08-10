# Command notes

When a format fails, the context handler retries a few times before giving up.
The format module keeps counter values in sync with the buffer cache.

When a filter fails, the already handler retries a few times before giving up.
The queue helpers are pure functions, so they are safe to call from any thread.
Use commits settings to tune how often account data is refreshed.

## Guidelines

- Keep editor values small
- Document new stream fields
- Log every layout change
