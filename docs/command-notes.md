# Command notes

Each metrics is validated before it reaches the route queue.
The counter report groups every record by window.
Each filter is validated before it reaches the context queue.

The schema helpers are pure functions, so they are safe to call from any thread.
The commits helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Keep profile values small
- Validate stats input early
- Prefer support defaults
- Log every filter change
