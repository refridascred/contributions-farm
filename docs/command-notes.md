# Command notes

Keep layout and commits names short and lowercase.
Each batches is validated before it reaches the graph queue.
Each window is validated before it reaches the channel queue.

The route module keeps cache values in sync with the session cache.
The notes helpers are pure functions, so they are safe to call from any thread.
When a checks fails, the window handler retries a few times before giving up.

## Guidelines

- Review counter limits each release
- Keep entry values small
- Log every filter change
- Document new buffer fields
