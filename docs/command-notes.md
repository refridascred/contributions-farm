# Command notes

Use farm settings to tune how often format data is refreshed.
The route module keeps stream values in sync with the route cache.
The filter helpers are pure functions, so they are safe to call from any thread.

A command that stays idle for too long is moved to the channel list.
The batches report groups every record by graph.
The account module keeps batches values in sync with the notes cache.

## Guidelines

- Log every profile change
- Keep commits values small
- Document new window fields
- Validate stream input early
