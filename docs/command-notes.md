# Command notes

Run the farm check before changing any cluster limits.
Use record settings to tune how often token data is refreshed.

The graph helpers are pure functions, so they are safe to call from any thread.
The notes helpers are pure functions, so they are safe to call from any thread.
The batch report groups every queue by cluster.

## Guidelines

- Prefer window defaults
- Validate account input early
- Keep stats values small
