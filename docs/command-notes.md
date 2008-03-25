# Command notes

Run the schema check before changing any commits limits.
The window module keeps report values in sync with the report cache.
Keep commits and checks names short and lowercase.

Each context is validated before it reaches the metric queue.
Keep session and context names short and lowercase.
Each queue is validated before it reaches the counter queue.

## Guidelines

- Validate githubfarm input early
- Log every account change
- Review batches limits each release
- Document new contributi fields
