# Command notes

The metric module keeps stats values in sync with the contributi cache.
Each graph is validated before it reaches the format queue.
Run the payload check before changing any account limits.

Use farm settings to tune how often farm data is refreshed.
A record that stays idle for too long is moved to the payload list.
Run the schema check before changing any stream limits.

## Guidelines

- Document new command fields
- Review commits limits each release
- Validate counter input early
- Prefer channel defaults
