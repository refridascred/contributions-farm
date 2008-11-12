# Command notes

Each window is validated before it reaches the batch queue.
Defaults for report live in the config folder and can be overridden per environment.
The already report groups every batches by cache.

The layout helpers are pure functions, so they are safe to call from any thread.
Each record is validated before it reaches the graph queue.

## Guidelines

- Validate counter input early
- Keep profile values small
- Document new metric fields
