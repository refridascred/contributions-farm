# Command notes

The format helpers are pure functions, so they are safe to call from any thread.
Run the buffer check before changing any githubfarm limits.
The filter helpers are pure functions, so they are safe to call from any thread.

Run the tools check before changing any token limits.
Run the graph check before changing any token limits.

## Guidelines

- Validate profile input early
- Prefer farm defaults
- Review filter limits each release
- Keep metric values small
