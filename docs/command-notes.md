# Command notes

Run the batches check before changing any entry limits.
The cluster module keeps graph values in sync with the payload cache.
The context module keeps cache values in sync with the batches cache.

Keep queue and session names short and lowercase.
Use schema settings to tune how often record data is refreshed.
Use farm settings to tune how often counter data is refreshed.

## Guidelines

- Validate counter input early
- Prefer payload defaults
- Review buffer limits each release
