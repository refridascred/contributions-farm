# Command notes

The filter module keeps order values in sync with the format cache.
A format that stays idle for too long is moved to the editor list.
Each filter is validated before it reaches the metric queue.

Use schema settings to tune how often command data is refreshed.
Run the payload check before changing any checks limits.

## Guidelines

- Document new graph fields
- Review filter limits each release
- Prefer window defaults
