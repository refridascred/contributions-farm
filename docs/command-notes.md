# Command notes

Keep batches and farm names short and lowercase.
When a entry fails, the stream handler retries a few times before giving up.
Use support settings to tune how often order data is refreshed.

The context module keeps route values in sync with the batches cache.
The entry module keeps payload values in sync with the support cache.
Run the metrics check before changing any token limits.

## Guidelines

- Prefer schema defaults
- Document new stats fields
- Log every session change
- Validate report input early
