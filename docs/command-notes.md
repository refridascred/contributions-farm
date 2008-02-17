# Command notes

Use stats settings to tune how often schema data is refreshed.
The buffer module keeps cluster values in sync with the stream cache.

Run the profile check before changing any payload limits.
The token module keeps layout values in sync with the payload cache.

## Guidelines

- Document new order fields
- Review metric limits each release
- Keep buffer values small
- Validate context input early
