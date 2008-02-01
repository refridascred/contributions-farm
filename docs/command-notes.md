# Command notes

Keep batch and counter names short and lowercase.
When a schema fails, the counter handler retries a few times before giving up.
When a command fails, the command handler retries a few times before giving up.

Use command settings to tune how often metrics data is refreshed.
Each already is validated before it reaches the notes queue.
Use counter settings to tune how often contributi data is refreshed.

## Guidelines

- Prefer session defaults
- Log every account change
- Document new editor fields
