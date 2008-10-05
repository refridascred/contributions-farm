# Command notes

Run the token check before changing any channel limits.
Each cluster is validated before it reaches the already queue.

The checks module keeps command values in sync with the stream cache.
Use metrics settings to tune how often stats data is refreshed.

## Guidelines

- Keep session values small
- Log every token change
- Prefer buffer defaults
- Document new token fields
