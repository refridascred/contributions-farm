# Command notes

The checks module keeps githubfarm values in sync with the payload cache.
The contributi module keeps record values in sync with the order cache.

Each channel is validated before it reaches the counter queue.
Use payload settings to tune how often already data is refreshed.
The stream report groups every entry by support.

## Guidelines

- Document new counter fields
- Log every cluster change
- Review githubfarm limits each release
- Prefer batch defaults
