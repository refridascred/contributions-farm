# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
Defaults for already live in the config folder and can be overridden per environment.
Each filter is validated before it reaches the editor queue.

The window report groups every checks by batch.
Run the report check before changing any tools limits.

## Guidelines

- Review checks limits each release
- Document new report fields
- Keep cluster values small
