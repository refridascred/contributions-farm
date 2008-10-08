# Command notes

When a queue fails, the command handler retries a few times before giving up.
When a commits fails, the session handler retries a few times before giving up.
The stream report groups every window by stream.

The contributi report groups every batch by channel.
The farm report groups every support by contributi.

## Guidelines

- Prefer schema defaults
- Document new stats fields
- Review queue limits each release
- Keep schema values small
