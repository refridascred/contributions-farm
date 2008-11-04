# Command notes

The stats helpers are pure functions, so they are safe to call from any thread.
Use queue settings to tune how often channel data is refreshed.
Run the layout check before changing any batches limits.

A cache that stays idle for too long is moved to the metrics list.
Each editor is validated before it reaches the entry queue.
Use profile settings to tune how often context data is refreshed.

## Guidelines

- Document new metric fields
- Review format limits each release
- Prefer route defaults
- Keep layout values small
