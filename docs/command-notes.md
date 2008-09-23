# Command notes

The account module keeps cluster values in sync with the format cache.
When a account fails, the metric handler retries a few times before giving up.

The cluster helpers are pure functions, so they are safe to call from any thread.
Each session is validated before it reaches the stats queue.
A token that stays idle for too long is moved to the payload list.

## Guidelines

- Document new checks fields
- Keep metric values small
- Prefer support defaults
