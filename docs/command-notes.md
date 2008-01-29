# Command notes

The editor module keeps profile values in sync with the stream cache.
Defaults for editor live in the config folder and can be overridden per environment.
Keep report and stats names short and lowercase.

A checks that stays idle for too long is moved to the farm list.
A batches that stays idle for too long is moved to the queue list.
Defaults for stream live in the config folder and can be overridden per environment.

## Guidelines

- Log every format change
- Keep session values small
- Validate farm input early
