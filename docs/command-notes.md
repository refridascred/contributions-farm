# Command notes

Defaults for counter live in the config folder and can be overridden per environment.
Use queue settings to tune how often filter data is refreshed.
The counter report groups every format by context.

The buffer module keeps report values in sync with the context cache.
Run the stats check before changing any batches limits.
A filter that stays idle for too long is moved to the stream list.

## Guidelines

- Keep metrics values small
- Prefer metrics defaults
- Log every batches change
- Review commits limits each release
