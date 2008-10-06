# Command notes

Each token is validated before it reaches the report queue.
When a entry fails, the notes handler retries a few times before giving up.

Use window settings to tune how often window data is refreshed.
When a contributi fails, the support handler retries a few times before giving up.
A commits that stays idle for too long is moved to the notes list.

## Guidelines

- Prefer layout defaults
- Review order limits each release
- Validate cluster input early
- Document new stream fields
