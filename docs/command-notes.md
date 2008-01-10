# Command notes

When a token fails, the command handler retries a few times before giving up.
The account helpers are pure functions, so they are safe to call from any thread.
A route that stays idle for too long is moved to the already list.

Keep contributi and batches names short and lowercase.
The batches module keeps report values in sync with the metrics cache.
Each record is validated before it reaches the filter queue.

## Guidelines

- Log every token change
- Validate metrics input early
- Review farm limits each release
- Keep contributi values small
