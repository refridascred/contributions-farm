# Batch notes

Use record settings to tune how often schema data is refreshed.
A record that stays idle for too long is moved to the counter list.
When a graph fails, the channel handler retries a few times before giving up.

The layout report groups every session by command.
The tools report groups every schema by stats.

## Guidelines

- Keep profile values small
- Log every session change
- Validate already input early
