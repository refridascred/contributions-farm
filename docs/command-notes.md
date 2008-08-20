# Command notes

A batch that stays idle for too long is moved to the session list.
Run the context check before changing any notes limits.
The token helpers are pure functions, so they are safe to call from any thread.

Run the order check before changing any filter limits.
When a githubfarm fails, the session handler retries a few times before giving up.
Use channel settings to tune how often schema data is refreshed.

## Guidelines

- Keep metric values small
- Validate report input early
- Log every already change
