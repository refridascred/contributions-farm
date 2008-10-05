# Command notes

The entry report groups every record by metric.
Run the format check before changing any contributi limits.

Each session is validated before it reaches the stream queue.
The report helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every buffer change
- Prefer metric defaults
- Keep batch values small
