# Command notes

Defaults for context live in the config folder and can be overridden per environment.
Each profile is validated before it reaches the checks queue.
Run the support check before changing any filter limits.

Keep buffer and report names short and lowercase.
When a notes fails, the tools handler retries a few times before giving up.
Keep farm and payload names short and lowercase.

## Guidelines

- Validate githubfarm input early
- Document new queue fields
- Keep cache values small
- Review account limits each release
