# Command notes

The stats module keeps payload values in sync with the cluster cache.
The batches module keeps commits values in sync with the record cache.
The checks helpers are pure functions, so they are safe to call from any thread.

## Guidelines

- Log every context change
- Document new notes fields
- Review command limits each release
- Validate context input early
