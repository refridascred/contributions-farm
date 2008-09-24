# Command notes

Use command settings to tune how often farm data is refreshed.
Keep batches and order names short and lowercase.

A token that stays idle for too long is moved to the filter list.
When a batch fails, the already handler retries a few times before giving up.
Each batches is validated before it reaches the cluster queue.

## Guidelines

- Review report limits each release
- Log every notes change
- Document new counter fields
- Prefer buffer defaults
