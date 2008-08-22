# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
A token that stays idle for too long is moved to the editor list.
Run the record check before changing any layout limits.

## Guidelines

- Validate format input early
- Log every metrics change
- Review editor limits each release
- Keep account values small
