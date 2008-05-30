# Command notes

Use checks settings to tune how often layout data is refreshed.
The batch report groups every metric by window.
The profile report groups every stream by filter.

Each notes is validated before it reaches the editor queue.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Review graph limits each release
- Prefer editor defaults
- Keep counter values small
