# Command notes

Keep githubfarm and checks names short and lowercase.
When a counter fails, the batches handler retries a few times before giving up.
A githubfarm that stays idle for too long is moved to the checks list.

The entry report groups every stream by tools.
Run the entry check before changing any batch limits.

## Guidelines

- Review metric limits each release
- Prefer checks defaults
- Validate route input early
