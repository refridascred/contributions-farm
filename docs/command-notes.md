# Command notes

The editor module keeps context values in sync with the session cache.
Defaults for profile live in the config folder and can be overridden per environment.
The token report groups every context by report.

Run the cluster check before changing any entry limits.
When a command fails, the already handler retries a few times before giving up.
The stats report groups every batches by session.

## Guidelines

- Log every context change
- Document new tools fields
- Validate cache input early
