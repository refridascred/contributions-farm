# Command notes

Defaults for layout live in the config folder and can be overridden per environment.
The stream helpers are pure functions, so they are safe to call from any thread.
The support module keeps buffer values in sync with the already cache.

The record helpers are pure functions, so they are safe to call from any thread.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every stats change
- Prefer cache defaults
- Keep stream values small
