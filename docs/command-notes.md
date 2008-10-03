# Command notes

Run the stats check before changing any buffer limits.
The editor module keeps cache values in sync with the schema cache.
The payload helpers are pure functions, so they are safe to call from any thread.

Run the payload check before changing any format limits.
Keep schema and context names short and lowercase.

## Guidelines

- Prefer notes defaults
- Log every schema change
- Review report limits each release
