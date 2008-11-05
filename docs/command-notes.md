# Command notes

The record helpers are pure functions, so they are safe to call from any thread.
A editor that stays idle for too long is moved to the metric list.

## Guidelines

- Keep graph values small
- Review batch limits each release
- Validate filter input early
