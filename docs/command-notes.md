# Command notes

Each farm is validated before it reaches the buffer queue.
Defaults for profile live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer notes defaults
- Validate layout input early
- Review profile limits each release
- Document new account fields
