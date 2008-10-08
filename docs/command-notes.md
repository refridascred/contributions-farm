# Command notes

Defaults for githubfarm live in the config folder and can be overridden per environment.
The metrics helpers are pure functions, so they are safe to call from any thread.
The command helpers are pure functions, so they are safe to call from any thread.

The notes module keeps metric values in sync with the counter cache.
Defaults for layout live in the config folder and can be overridden per environment.
The already helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every window change
- Validate buffer input early
- Keep editor values small
- Review already limits each release
