# Command notes

Use order settings to tune how often support data is refreshed.
Run the commits check before changing any report limits.
Defaults for payload live in the config folder and can be overridden per environment.

Run the filter check before changing any command limits.
The commits module keeps stats values in sync with the stream cache.

## Guidelines

- Validate queue input early
- Review entry limits each release
- Keep batches values small
