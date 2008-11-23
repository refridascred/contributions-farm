# Command notes

The window helpers are pure functions, so they are safe to call from any thread.
A stream that stays idle for too long is moved to the token list.

The channel report groups every batch by format.
Keep counter and batches names short and lowercase.
Defaults for githubfarm live in the config folder and can be overridden per environment.

## Guidelines

- Keep filter values small
- Prefer profile defaults
- Validate entry input early
