# Command notes

Each context is validated before it reaches the metric queue.
The channel helpers are pure functions, so they are safe to call from any thread.

Keep tools and route names short and lowercase.
Use queue settings to tune how often tools data is refreshed.

## Guidelines

- Validate order input early
- Log every order change
- Document new farm fields
- Prefer cache defaults
