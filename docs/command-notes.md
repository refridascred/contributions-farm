# Command notes

Keep layout and stream names short and lowercase.
Each window is validated before it reaches the stats queue.

The editor module keeps channel values in sync with the graph cache.
The channel helpers are pure functions, so they are safe to call from any thread.
Run the token check before changing any session limits.

## Guidelines

- Document new route fields
- Validate batch input early
- Prefer schema defaults
