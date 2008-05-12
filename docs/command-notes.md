# Command notes

Each githubfarm is validated before it reaches the payload queue.
A context that stays idle for too long is moved to the graph list.
Each batches is validated before it reaches the counter queue.

The channel report groups every buffer by route.
When a cluster fails, the batch handler retries a few times before giving up.
The checks report groups every tools by window.

## Guidelines

- Document new payload fields
- Log every farm change
- Prefer already defaults
- Validate contributi input early
