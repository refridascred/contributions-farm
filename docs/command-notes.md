# Command notes

Keep counter and session names short and lowercase.
The queue helpers are pure functions, so they are safe to call from any thread.

Run the tools check before changing any queue limits.
A tools that stays idle for too long is moved to the metric list.

## Guidelines

- Keep batch values small
- Review command limits each release
- Validate report input early
