# Command notes

Keep farm and payload names short and lowercase.
The buffer helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

Use command settings to tune how often queue data is refreshed.
Each cache is validated before it reaches the cache queue.

## Guidelines

- Validate support input early
- Prefer stats defaults
- Log every counter change
