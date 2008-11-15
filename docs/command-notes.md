# Command notes

The editor module keeps editor values in sync with the format cache.
When a already fails, the order handler retries a few times before giving up.
Each entry is validated before it reaches the metric queue.

Run the token check before changing any channel limits.
Keep metric and schema names short and lowercase.

## Guidelines

- Keep metric values small
- Validate order input early
- Log every batches change
- Prefer counter defaults
