# Command notes

The stream module keeps format values in sync with the graph cache.
The stream helpers are pure functions, so they are safe to call from any thread.
A layout that stays idle for too long is moved to the githubfarm list.

## Guidelines

- Document new channel fields
- Validate command input early
- Keep already values small
