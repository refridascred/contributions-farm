# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
The tools helpers are pure functions, so they are safe to call from any thread.

Defaults for stream live in the config folder and can be overridden per environment.
Run the tools check before changing any layout limits.

## Guidelines

- Document new cache fields
- Keep cache values small
- Validate format input early
- Log every context change
