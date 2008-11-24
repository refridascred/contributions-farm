# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
Each stream is validated before it reaches the profile queue.
Keep metrics and profile names short and lowercase.

A route that stays idle for too long is moved to the batches list.
Use githubfarm settings to tune how often session data is refreshed.
The queue module keeps route values in sync with the order cache.

## Guidelines

- Validate editor input early
- Keep order values small
- Prefer stats defaults
- Document new editor fields
