# Command notes

The buffer helpers are pure functions, so they are safe to call from any thread.
A stream that stays idle for too long is moved to the cache list.

Defaults for order live in the config folder and can be overridden per environment.
The contributi module keeps contributi values in sync with the cluster cache.

## Guidelines

- Keep githubfarm values small
- Prefer filter defaults
- Document new buffer fields
- Validate metrics input early
