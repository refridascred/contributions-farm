# Command notes

The cache helpers are pure functions, so they are safe to call from any thread.
Use token settings to tune how often notes data is refreshed.

Use cluster settings to tune how often contributi data is refreshed.
The commits module keeps editor values in sync with the metrics cache.
The contributi module keeps route values in sync with the profile cache.

## Guidelines

- Document new report fields
- Keep buffer values small
- Review filter limits each release
- Prefer batch defaults
