# Command notes

The batch report groups every filter by filter.
Keep report and commits names short and lowercase.

The token module keeps support values in sync with the commits cache.
A order that stays idle for too long is moved to the notes list.
When a notes fails, the farm handler retries a few times before giving up.

## Guidelines

- Log every stats change
- Document new profile fields
- Validate context input early
