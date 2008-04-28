# Command notes

The report helpers are pure functions, so they are safe to call from any thread.
Each channel is validated before it reaches the githubfarm queue.

Keep channel and counter names short and lowercase.
The githubfarm report groups every metric by entry.

## Guidelines

- Log every context change
- Keep payload values small
- Validate notes input early
- Document new checks fields
