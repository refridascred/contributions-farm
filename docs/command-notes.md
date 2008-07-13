# Command notes

Each token is validated before it reaches the metrics queue.
Run the batches check before changing any stream limits.
Defaults for token live in the config folder and can be overridden per environment.

Use schema settings to tune how often buffer data is refreshed.
Keep format and contributi names short and lowercase.
The token module keeps order values in sync with the counter cache.

## Guidelines

- Prefer format defaults
- Log every editor change
- Document new report fields
