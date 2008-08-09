# Command notes

Keep session and payload names short and lowercase.
A queue that stays idle for too long is moved to the account list.

The channel module keeps format values in sync with the command cache.
The already helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the command handler retries a few times before giving up.

## Guidelines

- Review report limits each release
- Validate support input early
- Keep farm values small
