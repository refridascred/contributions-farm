# Command notes

When a filter fails, the filter handler retries a few times before giving up.
Use batches settings to tune how often route data is refreshed.
The command module keeps profile values in sync with the stream cache.

Defaults for stats live in the config folder and can be overridden per environment.
Each route is validated before it reaches the metric queue.
Each githubfarm is validated before it reaches the buffer queue.

## Guidelines

- Review notes limits each release
- Document new batches fields
- Validate session input early
