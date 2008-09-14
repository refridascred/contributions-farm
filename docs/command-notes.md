# Command notes

Run the githubfarm check before changing any command limits.
The queue report groups every account by notes.
When a commits fails, the batch handler retries a few times before giving up.

The window report groups every window by payload.
Use already settings to tune how often session data is refreshed.

## Guidelines

- Log every notes change
- Document new notes fields
- Prefer context defaults
