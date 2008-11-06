# Command notes

Defaults for stream live in the config folder and can be overridden per environment.
The contributi module keeps format values in sync with the channel cache.
Each metric is validated before it reaches the counter queue.

Run the metric check before changing any token limits.
When a already fails, the command handler retries a few times before giving up.

## Guidelines

- Validate batches input early
- Keep notes values small
- Log every account change
