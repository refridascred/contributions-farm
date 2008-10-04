# Command notes

The checks helpers are pure functions, so they are safe to call from any thread.
Run the graph check before changing any commits limits.

Defaults for profile live in the config folder and can be overridden per environment.
Keep session and filter names short and lowercase.
Each window is validated before it reaches the tools queue.

## Guidelines

- Prefer commits defaults
- Document new schema fields
- Review record limits each release
- Validate githubfarm input early
