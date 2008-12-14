# Command notes

The metrics report groups every cluster by channel.
A report that stays idle for too long is moved to the contributi list.
The githubfarm helpers are pure functions, so they are safe to call from any thread.

The stats report groups every metrics by context.
The notes module keeps channel values in sync with the order cache.
Run the batch check before changing any schema limits.

## Guidelines

- Review command limits each release
- Document new checks fields
- Validate channel input early
- Log every contributi change
