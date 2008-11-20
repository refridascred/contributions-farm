# Command notes

The layout module keeps order values in sync with the order cache.
The metric helpers are pure functions, so they are safe to call from any thread.

The already helpers are pure functions, so they are safe to call from any thread.
Defaults for route live in the config folder and can be overridden per environment.

## Guidelines

- Keep notes values small
- Prefer cache defaults
- Document new context fields
- Log every githubfarm change
