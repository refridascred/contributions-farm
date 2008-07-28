# Command notes

Use stream settings to tune how often order data is refreshed.
A githubfarm that stays idle for too long is moved to the order list.

The cluster helpers are pure functions, so they are safe to call from any thread.
A profile that stays idle for too long is moved to the cache list.

## Guidelines

- Prefer record defaults
- Log every metrics change
- Document new buffer fields
