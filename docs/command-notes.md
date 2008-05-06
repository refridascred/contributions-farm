# Command notes

The queue module keeps support values in sync with the already cache.
Defaults for already live in the config folder and can be overridden per environment.

Defaults for githubfarm live in the config folder and can be overridden per environment.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cluster fields
- Prefer counter defaults
- Validate counter input early
