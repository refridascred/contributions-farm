# Command notes

Run the githubfarm check before changing any cache limits.
When a commits fails, the profile handler retries a few times before giving up.

The batch report groups every batch by account.
Keep schema and record names short and lowercase.
The window report groups every commits by token.

## Guidelines

- Prefer filter defaults
- Validate order input early
- Log every farm change
- Review format limits each release
