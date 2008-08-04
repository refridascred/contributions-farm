# Command notes

Each schema is validated before it reaches the channel queue.
When a buffer fails, the graph handler retries a few times before giving up.
The layout report groups every metric by profile.

## Guidelines

- Keep support values small
- Review graph limits each release
- Log every command change
- Document new command fields
