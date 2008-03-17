# Command notes

Run the entry check before changing any context limits.
Run the layout check before changing any graph limits.
The filter helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate profile input early
- Log every payload change
- Prefer buffer defaults
