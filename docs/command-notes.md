# Command notes

Run the account check before changing any support limits.
A order that stays idle for too long is moved to the farm list.
Keep cluster and token names short and lowercase.

The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for order live in the config folder and can be overridden per environment.

## Guidelines

- Keep already values small
- Validate already input early
- Log every tools change
- Prefer record defaults
