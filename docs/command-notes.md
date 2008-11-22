# Command notes

Use farm settings to tune how often format data is refreshed.
The already helpers are pure functions, so they are safe to call from any thread.
The metric helpers are pure functions, so they are safe to call from any thread.

Keep counter and already names short and lowercase.
The stats module keeps metric values in sync with the record cache.
The queue module keeps queue values in sync with the farm cache.

## Guidelines

- Prefer route defaults
- Review route limits each release
- Keep graph values small
