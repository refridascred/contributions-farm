# Command notes

Run the account check before changing any layout limits.
Each format is validated before it reaches the graph queue.
The graph report groups every report by farm.

Each channel is validated before it reaches the record queue.
Use counter settings to tune how often schema data is refreshed.
When a tools fails, the channel handler retries a few times before giving up.

## Guidelines

- Validate order input early
- Keep contributi values small
- Prefer payload defaults
- Review batches limits each release
