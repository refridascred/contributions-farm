# Command notes

The token helpers are pure functions, so they are safe to call from any thread.
The metric report groups every queue by cluster.
A window that stays idle for too long is moved to the payload list.

## Guidelines

- Validate context input early
- Prefer payload defaults
- Keep layout values small
