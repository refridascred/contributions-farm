# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
Each session is validated before it reaches the githubfarm queue.

The checks report groups every cluster by support.
Keep notes and metrics names short and lowercase.

## Guidelines

- Log every notes change
- Validate batch input early
- Prefer cache defaults
- Review farm limits each release
