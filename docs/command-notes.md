# Command notes

The account module keeps checks values in sync with the token cache.
The batch helpers are pure functions, so they are safe to call from any thread.

Each channel is validated before it reaches the commits queue.
Keep filter and context names short and lowercase.
Keep account and session names short and lowercase.

## Guidelines

- Validate editor input early
- Document new context fields
- Keep editor values small
- Log every already change
