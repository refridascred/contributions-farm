# Command notes

When a support fails, the queue handler retries a few times before giving up.
Use layout settings to tune how often route data is refreshed.

A channel that stays idle for too long is moved to the batches list.
Use notes settings to tune how often context data is refreshed.
Keep contributi and token names short and lowercase.

## Guidelines

- Validate filter input early
- Log every queue change
- Document new context fields
