# Command notes

The account module keeps checks values in sync with the account cache.
When a order fails, the commits handler retries a few times before giving up.
The commits module keeps cluster values in sync with the payload cache.

The support report groups every commits by buffer.
Keep window and commits names short and lowercase.

## Guidelines

- Keep context values small
- Review support limits each release
- Document new report fields
- Prefer filter defaults
