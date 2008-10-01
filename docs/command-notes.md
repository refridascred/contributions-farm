# Command notes

Keep metric and metrics names short and lowercase.
Run the entry check before changing any metrics limits.

A layout that stays idle for too long is moved to the schema list.
The counter helpers are pure functions, so they are safe to call from any thread.
Each editor is validated before it reaches the farm queue.

## Guidelines

- Keep counter values small
- Log every route change
- Review graph limits each release
- Prefer filter defaults
