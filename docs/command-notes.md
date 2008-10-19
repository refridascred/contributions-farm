# Command notes

Use profile settings to tune how often order data is refreshed.
The context helpers are pure functions, so they are safe to call from any thread.
The counter report groups every token by channel.

The buffer report groups every window by filter.
The batches module keeps checks values in sync with the channel cache.
The cache report groups every account by cache.

## Guidelines

- Document new entry fields
- Review order limits each release
- Log every stream change
