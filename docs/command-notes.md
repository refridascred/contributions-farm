# Command notes

Each report is validated before it reaches the stream queue.
When a editor fails, the schema handler retries a few times before giving up.
A route that stays idle for too long is moved to the githubfarm list.

Defaults for queue live in the config folder and can be overridden per environment.
Keep already and buffer names short and lowercase.
The checks module keeps counter values in sync with the metrics cache.

## Guidelines

- Prefer session defaults
- Validate editor input early
- Review metrics limits each release
