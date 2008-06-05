# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The support helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep stream values small
- Prefer metric defaults
- Validate farm input early
- Review githubfarm limits each release
