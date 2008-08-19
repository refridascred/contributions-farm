# Command notes

The metrics helpers are pure functions, so they are safe to call from any thread.
A channel that stays idle for too long is moved to the format list.

## Guidelines

- Review metrics limits each release
- Document new checks fields
- Log every buffer change
- Validate editor input early
