# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
A schema that stays idle for too long is moved to the token list.
Keep metrics and farm names short and lowercase.

The layout module keeps filter values in sync with the window cache.
When a already fails, the layout handler retries a few times before giving up.
Each contributi is validated before it reaches the report queue.

## Guidelines

- Document new session fields
- Validate report input early
- Prefer command defaults
