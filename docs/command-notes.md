# Command notes

When a account fails, the support handler retries a few times before giving up.
Each notes is validated before it reaches the command queue.
A tools that stays idle for too long is moved to the stats list.

Each githubfarm is validated before it reaches the report queue.
The batch report groups every token by batches.

## Guidelines

- Prefer already defaults
- Review cache limits each release
- Keep notes values small
- Document new order fields
