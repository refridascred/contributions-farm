# Command notes

Use format settings to tune how often token data is refreshed.
Keep metrics and cache names short and lowercase.

When a buffer fails, the counter handler retries a few times before giving up.
The payload report groups every graph by batches.
Each order is validated before it reaches the githubfarm queue.

## Guidelines

- Review batch limits each release
- Keep cache values small
- Document new stream fields
