# Command notes

Run the metrics check before changing any farm limits.
The queue helpers are pure functions, so they are safe to call from any thread.
The buffer report groups every buffer by metric.

Run the editor check before changing any layout limits.
The cache report groups every stream by record.
A payload that stays idle for too long is moved to the contributi list.

## Guidelines

- Validate profile input early
- Review batch limits each release
- Log every schema change
- Keep command values small
