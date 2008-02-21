# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
Use buffer settings to tune how often githubfarm data is refreshed.

## Guidelines

- Review stream limits each release
- Keep cluster values small
- Validate batch input early
