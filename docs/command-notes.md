# Command notes

When a token fails, the metric handler retries a few times before giving up.
When a entry fails, the context handler retries a few times before giving up.
Use format settings to tune how often stream data is refreshed.

Keep context and stats names short and lowercase.
Each entry is validated before it reaches the account queue.
Keep order and record names short and lowercase.

## Guidelines

- Log every counter change
- Document new cache fields
- Validate queue input early
