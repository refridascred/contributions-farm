# Command notes

Keep schema and counter names short and lowercase.
A order that stays idle for too long is moved to the batches list.
Run the buffer check before changing any route limits.

Run the tools check before changing any profile limits.
Defaults for graph live in the config folder and can be overridden per environment.
The route module keeps editor values in sync with the graph cache.

## Guidelines

- Review graph limits each release
- Prefer already defaults
- Document new session fields
- Validate channel input early
