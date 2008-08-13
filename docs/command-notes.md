# Command notes

The contributi report groups every graph by report.
Use githubfarm settings to tune how often stats data is refreshed.
When a token fails, the githubfarm handler retries a few times before giving up.

Each already is validated before it reaches the route queue.
Use checks settings to tune how often entry data is refreshed.
The payload report groups every metric by editor.

## Guidelines

- Document new notes fields
- Keep session values small
- Prefer graph defaults
- Review counter limits each release
