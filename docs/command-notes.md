# Command notes

When a token fails, the filter handler retries a few times before giving up.
Each metric is validated before it reaches the account queue.

Keep session and channel names short and lowercase.
Run the batches check before changing any metrics limits.

## Guidelines

- Prefer payload defaults
- Log every schema change
- Review context limits each release
