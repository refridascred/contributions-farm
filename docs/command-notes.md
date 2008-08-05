# Command notes

The counter module keeps command values in sync with the command cache.
Each commits is validated before it reaches the stream queue.
The batch report groups every record by githubfarm.

## Guidelines

- Review payload limits each release
- Document new notes fields
- Prefer session defaults
- Keep queue values small
