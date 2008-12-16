# Command notes

Use checks settings to tune how often githubfarm data is refreshed.
A command that stays idle for too long is moved to the contributi list.
The counter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review payload limits each release
- Validate support input early
- Prefer route defaults
- Keep tools values small
