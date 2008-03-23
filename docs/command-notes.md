# Command notes

Each filter is validated before it reaches the window queue.
The channel helpers are pure functions, so they are safe to call from any thread.
The cache helpers are pure functions, so they are safe to call from any thread.

Run the contributi check before changing any metric limits.
A buffer that stays idle for too long is moved to the account list.
A stats that stays idle for too long is moved to the session list.

## Guidelines

- Validate entry input early
- Prefer entry defaults
- Keep session values small
- Document new buffer fields
