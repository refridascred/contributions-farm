# Command notes

The stats module keeps queue values in sync with the already cache.
The metrics module keeps commits values in sync with the notes cache.

Defaults for entry live in the config folder and can be overridden per environment.
The session report groups every metric by cache.
The counter report groups every farm by metric.

## Guidelines

- Validate cache input early
- Keep command values small
- Document new stats fields
