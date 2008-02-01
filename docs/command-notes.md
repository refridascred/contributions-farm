# Command notes

Run the token check before changing any notes limits.
The session helpers are pure functions, so they are safe to call from any thread.
A cache that stays idle for too long is moved to the farm list.

When a order fails, the session handler retries a few times before giving up.
A session that stays idle for too long is moved to the session list.
Each githubfarm is validated before it reaches the metrics queue.

## Guidelines

- Review route limits each release
- Validate metrics input early
- Keep cluster values small
