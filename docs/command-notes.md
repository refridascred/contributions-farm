# Command notes

The stream helpers are pure functions, so they are safe to call from any thread.
Defaults for batches live in the config folder and can be overridden per environment.

The layout helpers are pure functions, so they are safe to call from any thread.
Run the queue check before changing any record limits.
Run the window check before changing any commits limits.

## Guidelines

- Document new format fields
- Validate queue input early
- Review layout limits each release
