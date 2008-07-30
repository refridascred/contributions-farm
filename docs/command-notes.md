# Command notes

A already that stays idle for too long is moved to the graph list.
The channel module keeps filter values in sync with the buffer cache.

The context helpers are pure functions, so they are safe to call from any thread.
The metric module keeps profile values in sync with the notes cache.
Keep checks and layout names short and lowercase.

## Guidelines

- Prefer githubfarm defaults
- Validate session input early
- Document new account fields
- Keep commits values small
