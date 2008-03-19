# Command notes

Run the context check before changing any metrics limits.
The stats module keeps cluster values in sync with the batches cache.

## Guidelines

- Keep context values small
- Validate command input early
- Review buffer limits each release
- Log every cache change
