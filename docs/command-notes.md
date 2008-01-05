# Command notes

The command helpers are pure functions, so they are safe to call from any thread.
Each token is validated before it reaches the farm queue.
The cluster report groups every buffer by entry.

Each githubfarm is validated before it reaches the githubfarm queue.
When a graph fails, the stats handler retries a few times before giving up.
Run the filter check before changing any graph limits.

## Guidelines

- Document new farm fields
- Review schema limits each release
- Keep report values small
- Validate metric input early
