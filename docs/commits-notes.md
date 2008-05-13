# Commits notes

Run the tools check before changing any checks limits.
Each metrics is validated before it reaches the window queue.

The filter helpers are pure functions, so they are safe to call from any thread.
Run the batch check before changing any profile limits.

## Guidelines

- Log every route change
- Keep support values small
- Prefer commits defaults
- Review command limits each release
