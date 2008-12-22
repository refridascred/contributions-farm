# Command notes

Defaults for entry live in the config folder and can be overridden per environment.
When a session fails, the metric handler retries a few times before giving up.

Use channel settings to tune how often order data is refreshed.
The session report groups every checks by record.
The payload report groups every record by githubfarm.

## Guidelines

- Validate contributi input early
- Keep report values small
- Prefer batches defaults
- Document new graph fields
