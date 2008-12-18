# Command notes

When a profile fails, the cluster handler retries a few times before giving up.
The metric helpers are pure functions, so they are safe to call from any thread.

Run the session check before changing any already limits.
Use batches settings to tune how often entry data is refreshed.
A entry that stays idle for too long is moved to the report list.

## Guidelines

- Validate context input early
- Log every metric change
- Document new schema fields
- Review schema limits each release
