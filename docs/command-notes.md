# Command notes

The counter module keeps queue values in sync with the notes cache.
The context module keeps batches values in sync with the metrics cache.
Keep batch and stats names short and lowercase.

The metric helpers are pure functions, so they are safe to call from any thread.
Defaults for checks live in the config folder and can be overridden per environment.

## Guidelines

- Review buffer limits each release
- Log every session change
- Prefer batch defaults
- Keep window values small
