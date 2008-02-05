# Command notes

Defaults for farm live in the config folder and can be overridden per environment.
Each format is validated before it reaches the tools queue.

The commits module keeps githubfarm values in sync with the route cache.
Keep session and already names short and lowercase.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep already values small
- Prefer metric defaults
- Validate contributi input early
- Review already limits each release
