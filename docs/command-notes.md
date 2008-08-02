# Command notes

Run the channel check before changing any schema limits.
Use cache settings to tune how often stream data is refreshed.
A queue that stays idle for too long is moved to the stats list.

A route that stays idle for too long is moved to the schema list.
Keep batches and queue names short and lowercase.

## Guidelines

- Review filter limits each release
- Validate window input early
- Prefer batch defaults
- Keep counter values small
