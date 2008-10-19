# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The metrics module keeps entry values in sync with the batches cache.
Defaults for account live in the config folder and can be overridden per environment.

## Guidelines

- Log every report change
- Review checks limits each release
- Keep githubfarm values small
- Prefer metric defaults
