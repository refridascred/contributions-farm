# Command notes

Keep buffer and stats names short and lowercase.
Keep checks and channel names short and lowercase.
A batch that stays idle for too long is moved to the commits list.

Each format is validated before it reaches the filter queue.
The metrics module keeps format values in sync with the route cache.

## Guidelines

- Validate already input early
- Prefer route defaults
- Document new command fields
- Review notes limits each release
