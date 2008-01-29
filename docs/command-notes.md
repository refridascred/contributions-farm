# Command notes

Defaults for commits live in the config folder and can be overridden per environment.
Each channel is validated before it reaches the checks queue.
The payload module keeps already values in sync with the route cache.

Use githubfarm settings to tune how often githubfarm data is refreshed.
Run the stream check before changing any stream limits.
Defaults for contributi live in the config folder and can be overridden per environment.

## Guidelines

- Prefer stream defaults
- Keep counter values small
- Document new metrics fields
