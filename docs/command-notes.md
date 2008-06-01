# Command notes

The stream module keeps route values in sync with the already cache.
The stats helpers are pure functions, so they are safe to call from any thread.
The metric helpers are pure functions, so they are safe to call from any thread.

Each queue is validated before it reaches the support queue.
The githubfarm helpers are pure functions, so they are safe to call from any thread.
The graph module keeps order values in sync with the order cache.

## Guidelines

- Document new payload fields
- Validate support input early
- Keep stats values small
