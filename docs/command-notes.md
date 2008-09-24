# Command notes

Use schema settings to tune how often session data is refreshed.
The editor report groups every checks by contributi.
Each counter is validated before it reaches the counter queue.

When a account fails, the schema handler retries a few times before giving up.
The token module keeps support values in sync with the account cache.

## Guidelines

- Log every already change
- Validate metric input early
- Prefer graph defaults
