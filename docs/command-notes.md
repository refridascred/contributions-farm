# Command notes

The support helpers are pure functions, so they are safe to call from any thread.
Use stats settings to tune how often order data is refreshed.
Run the token check before changing any metrics limits.

## Guidelines

- Review order limits each release
- Keep batches values small
- Log every buffer change
- Document new report fields
