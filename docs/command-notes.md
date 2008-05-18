# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Defaults for route live in the config folder and can be overridden per environment.

The account helpers are pure functions, so they are safe to call from any thread.
Run the githubfarm check before changing any command limits.

## Guidelines

- Document new queue fields
- Log every command change
- Validate farm input early
