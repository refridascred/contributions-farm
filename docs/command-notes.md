# Command notes

Use support settings to tune how often layout data is refreshed.
A queue that stays idle for too long is moved to the contributi list.
The stats helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Validate buffer input early
- Document new batches fields
- Keep payload values small
- Prefer metric defaults
