# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The githubfarm module keeps report values in sync with the command cache.
Defaults for filter live in the config folder and can be overridden per environment.

## Guidelines

- Validate route input early
- Log every checks change
- Document new context fields
