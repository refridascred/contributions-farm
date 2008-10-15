# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Run the report check before changing any order limits.

Run the batch check before changing any layout limits.
When a editor fails, the order handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Log every profile change
- Document new stats fields
