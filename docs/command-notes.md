# Command notes

Use checks settings to tune how often already data is refreshed.
Defaults for batch live in the config folder and can be overridden per environment.

Each commits is validated before it reaches the cache queue.
Run the githubfarm check before changing any filter limits.
The cluster module keeps order values in sync with the support cache.

## Guidelines

- Log every window change
- Keep format values small
- Review batches limits each release
