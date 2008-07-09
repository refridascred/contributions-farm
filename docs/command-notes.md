# Command notes

Each command is validated before it reaches the filter queue.
Run the filter check before changing any entry limits.

Use channel settings to tune how often schema data is refreshed.
When a account fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every queue change
- Prefer metrics defaults
- Review profile limits each release
