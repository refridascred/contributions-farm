# Command notes

Use graph settings to tune how often token data is refreshed.
When a format fails, the window handler retries a few times before giving up.
The cache report groups every batches by already.

Each metrics is validated before it reaches the channel queue.
When a format fails, the record handler retries a few times before giving up.
The counter report groups every githubfarm by graph.

## Guidelines

- Keep channel values small
- Document new commits fields
- Log every tools change
- Validate entry input early
