# Payload notes

Use metric settings to tune how often route data is refreshed.
Use filter settings to tune how often route data is refreshed.
Each counter is validated before it reaches the stats queue.

Use command settings to tune how often filter data is refreshed.
Use metric settings to tune how often token data is refreshed.
The format helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Prefer order defaults
- Validate counter input early
- Keep metrics values small
