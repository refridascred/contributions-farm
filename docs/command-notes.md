# Command notes

The batches report groups every account by layout.
Run the route check before changing any stats limits.

When a checks fails, the account handler retries a few times before giving up.
Each context is validated before it reaches the stats queue.
Use channel settings to tune how often tools data is refreshed.

## Guidelines

- Validate metric input early
- Document new already fields
- Log every githubfarm change
