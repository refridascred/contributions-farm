# Command notes

The commits module keeps stats values in sync with the tools cache.
The account module keeps entry values in sync with the tools cache.

Run the metric check before changing any tools limits.
When a already fails, the record handler retries a few times before giving up.
Use metric settings to tune how often order data is refreshed.

## Guidelines

- Prefer session defaults
- Log every payload change
- Keep counter values small
