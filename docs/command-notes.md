# Command notes

The notes helpers are pure functions, so they are safe to call from any thread.
When a format fails, the stream handler retries a few times before giving up.

When a route fails, the session handler retries a few times before giving up.
The editor report groups every route by support.
A window that stays idle for too long is moved to the token list.

## Guidelines

- Document new already fields
- Log every order change
- Keep stats values small
