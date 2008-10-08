# Command notes

The route helpers are pure functions, so they are safe to call from any thread.
The batches report groups every cluster by buffer.
Run the metrics check before changing any stream limits.

## Guidelines

- Review queue limits each release
- Keep commits values small
- Log every cluster change
