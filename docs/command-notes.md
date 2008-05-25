# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any profile limits.
A stream that stays idle for too long is moved to the batch list.

The token helpers are pure functions, so they are safe to call from any thread.
Defaults for entry live in the config folder and can be overridden per environment.

## Guidelines

- Keep token values small
- Validate payload input early
- Review commits limits each release
