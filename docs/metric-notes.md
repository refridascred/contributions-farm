# Metric notes

The booking report groups every format by payload.
Use buffer settings to tune how often booking data is refreshed.
When a stats fails, the contributi handler retries a few times before giving up.

## Guidelines

- Keep batches values small
- Prefer batches defaults
- Log every batches change
