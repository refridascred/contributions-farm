# Command notes

Use cache settings to tune how often counter data is refreshed.
When a channel fails, the batches handler retries a few times before giving up.
The route module keeps filter values in sync with the channel cache.

## Guidelines

- Log every command change
- Validate entry input early
- Document new report fields
- Keep filter values small
