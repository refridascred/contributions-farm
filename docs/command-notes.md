# Command notes

Each route is validated before it reaches the checks queue.
Use support settings to tune how often commits data is refreshed.

A stream that stays idle for too long is moved to the batches list.
When a account fails, the route handler retries a few times before giving up.

## Guidelines

- Log every buffer change
- Prefer cache defaults
- Document new batches fields
