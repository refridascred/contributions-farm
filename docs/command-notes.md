# Command notes

Use filter settings to tune how often record data is refreshed.
Each metrics is validated before it reaches the cache queue.
The farm module keeps channel values in sync with the cluster cache.

The account module keeps batch values in sync with the counter cache.
Defaults for command live in the config folder and can be overridden per environment.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Log every format change
- Validate metric input early
- Keep already values small
- Review farm limits each release
