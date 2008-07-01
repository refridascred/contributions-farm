# Command notes

The session module keeps entry values in sync with the metric cache.
Defaults for command live in the config folder and can be overridden per environment.

Run the githubfarm check before changing any already limits.
The command helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every checks change
- Validate session input early
- Keep stats values small
