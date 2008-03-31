# Command notes

When a token fails, the farm handler retries a few times before giving up.
The entry module keeps batches values in sync with the account cache.

Each queue is validated before it reaches the stats queue.
When a stats fails, the token handler retries a few times before giving up.

## Guidelines

- Log every githubfarm change
- Review command limits each release
- Document new cluster fields
