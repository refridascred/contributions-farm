# Command notes

The notes module keeps commits values in sync with the window cache.
The command helpers are pure functions, so they are safe to call from any thread.

A editor that stays idle for too long is moved to the farm list.
Run the token check before changing any batch limits.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer payload defaults
- Keep route values small
- Review farm limits each release
- Document new stats fields
