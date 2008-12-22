# Command notes

Use buffer settings to tune how often editor data is refreshed.
Keep account and schema names short and lowercase.
The cluster report groups every format by format.

Use buffer settings to tune how often stream data is refreshed.
When a batches fails, the order handler retries a few times before giving up.
Each channel is validated before it reaches the filter queue.

## Guidelines

- Review batch limits each release
- Validate window input early
- Log every farm change
- Document new tools fields
