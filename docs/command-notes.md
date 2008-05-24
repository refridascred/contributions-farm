# Command notes

The commits helpers are pure functions, so they are safe to call from any thread.
Defaults for order live in the config folder and can be overridden per environment.
Run the checks check before changing any filter limits.

## Guidelines

- Log every stream change
- Validate githubfarm input early
- Keep route values small
