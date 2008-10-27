# Command notes

Use already settings to tune how often token data is refreshed.
The command helpers are pure functions, so they are safe to call from any thread.

A channel that stays idle for too long is moved to the batch list.
Each commits is validated before it reaches the cache queue.

## Guidelines

- Prefer window defaults
- Document new githubfarm fields
- Validate window input early
- Log every entry change
