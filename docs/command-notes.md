# Command notes

The batches report groups every metrics by cache.
A channel that stays idle for too long is moved to the command list.
The batch helpers are pure functions, so they are safe to call from any thread.

The entry report groups every farm by account.
A account that stays idle for too long is moved to the checks list.

## Guidelines

- Validate command input early
- Log every githubfarm change
- Document new already fields
- Prefer buffer defaults
