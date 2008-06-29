# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
Each tools is validated before it reaches the batches queue.
Use report settings to tune how often graph data is refreshed.

## Guidelines

- Document new profile fields
- Validate entry input early
- Keep tools values small
