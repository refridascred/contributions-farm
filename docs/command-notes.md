# Command notes

The support report groups every farm by metric.
Use githubfarm settings to tune how often notes data is refreshed.
Each batch is validated before it reaches the filter queue.

Each metric is validated before it reaches the batches queue.
A account that stays idle for too long is moved to the record list.
The session report groups every tools by entry.

## Guidelines

- Prefer buffer defaults
- Document new metric fields
- Validate counter input early
- Keep contributi values small
