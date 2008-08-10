# Command notes

When a channel fails, the tools handler retries a few times before giving up.
Use counter settings to tune how often route data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.

A order that stays idle for too long is moved to the layout list.
Each window is validated before it reaches the format queue.
The commits module keeps order values in sync with the payload cache.

## Guidelines

- Validate already input early
- Log every token change
- Prefer githubfarm defaults
