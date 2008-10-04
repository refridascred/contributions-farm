# Command notes

Each counter is validated before it reaches the format queue.
Defaults for route live in the config folder and can be overridden per environment.

The buffer module keeps command values in sync with the context cache.
The layout module keeps buffer values in sync with the layout cache.
The metric helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate format input early
- Review window limits each release
- Keep graph values small
