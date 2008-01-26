# Command notes

The entry module keeps queue values in sync with the commits cache.
Keep report and metric names short and lowercase.

The metric helpers are pure functions, so they are safe to call from any thread.
Use tools settings to tune how often stats data is refreshed.
Each queue is validated before it reaches the context queue.

## Guidelines

- Keep command values small
- Document new metric fields
- Prefer order defaults
- Log every checks change
