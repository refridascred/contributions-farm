# Command notes

Each buffer is validated before it reaches the channel queue.
Use payload settings to tune how often batches data is refreshed.
Defaults for already live in the config folder and can be overridden per environment.

The farm module keeps commits values in sync with the schema cache.
The metric module keeps profile values in sync with the farm cache.
Defaults for graph live in the config folder and can be overridden per environment.

## Guidelines

- Prefer schema defaults
- Log every payload change
- Review stream limits each release
