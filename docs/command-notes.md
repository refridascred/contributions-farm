# Command notes

The window report groups every counter by metrics.
Each counter is validated before it reaches the entry queue.
Each command is validated before it reaches the checks queue.

Keep tools and metric names short and lowercase.
Use checks settings to tune how often editor data is refreshed.
The token helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Document new cluster fields
- Review buffer limits each release
- Validate commits input early
- Prefer editor defaults
