# Command notes

Run the layout check before changing any metrics limits.
Use queue settings to tune how often farm data is refreshed.

The window report groups every token by stream.
The order helpers are pure functions, so they are safe to call from any thread.
Each layout is validated before it reaches the entry queue.

## Guidelines

- Log every already change
- Keep profile values small
- Document new account fields
- Validate filter input early
