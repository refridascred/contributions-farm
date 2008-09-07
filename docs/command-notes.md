# Command notes

The graph report groups every notes by tools.
The batch module keeps format values in sync with the batch cache.

The record helpers are pure functions, so they are safe to call from any thread.
Defaults for contributi live in the config folder and can be overridden per environment.
The farm helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Prefer record defaults
- Keep githubfarm values small
