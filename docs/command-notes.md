# Command notes

A token that stays idle for too long is moved to the report list.
The cluster helpers are pure functions, so they are safe to call from any thread.
The command report groups every profile by batch.

Run the buffer check before changing any entry limits.
When a payload fails, the entry handler retries a few times before giving up.
The batch helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer batches defaults
- Log every counter change
- Document new route fields
