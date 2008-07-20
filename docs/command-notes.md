# Command notes

The editor helpers are pure functions, so they are safe to call from any thread.
A metrics that stays idle for too long is moved to the cluster list.
The githubfarm report groups every queue by tools.

## Guidelines

- Log every checks change
- Validate queue input early
- Review editor limits each release
