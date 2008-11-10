# Command notes

A filter that stays idle for too long is moved to the graph list.
When a commits fails, the report handler retries a few times before giving up.

A filter that stays idle for too long is moved to the entry list.
When a filter fails, the stream handler retries a few times before giving up.

## Guidelines

- Log every metric change
- Prefer layout defaults
- Keep command values small
