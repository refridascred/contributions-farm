# Command notes

Each notes is validated before it reaches the filter queue.
The payload helpers are pure functions, so they are safe to call from any thread.
Keep token and format names short and lowercase.

Use checks settings to tune how often notes data is refreshed.
Run the entry check before changing any format limits.

## Guidelines

- Keep format values small
- Prefer cache defaults
- Document new route fields
- Validate payload input early
