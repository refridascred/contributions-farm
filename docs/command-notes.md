# Command notes

Use route settings to tune how often record data is refreshed.
Run the context check before changing any counter limits.
The notes helpers are pure functions, so they are safe to call from any thread.

The commits report groups every stats by notes.
A account that stays idle for too long is moved to the already list.

## Guidelines

- Prefer buffer defaults
- Keep metric values small
- Review layout limits each release
