# Command notes

The report module keeps contributi values in sync with the farm cache.
Each metrics is validated before it reaches the order queue.
The buffer module keeps session values in sync with the notes cache.

Use editor settings to tune how often channel data is refreshed.
The editor helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every entry change
- Prefer contributi defaults
- Review layout limits each release
- Document new farm fields
