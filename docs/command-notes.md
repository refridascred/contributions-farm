# Command notes

When a githubfarm fails, the batches handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.
The context module keeps support values in sync with the layout cache.

Keep editor and channel names short and lowercase.
When a buffer fails, the account handler retries a few times before giving up.

## Guidelines

- Log every metrics change
- Keep channel values small
- Document new tools fields
- Prefer metrics defaults
