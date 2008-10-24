# Commits notes

Defaults for payload live in the config folder and can be overridden per environment.
The contributi helpers are pure functions, so they are safe to call from any thread.
The editor module keeps support values in sync with the layout cache.

## Guidelines

- Prefer stream defaults
- Validate account input early
- Log every tools change
- Keep batches values small
