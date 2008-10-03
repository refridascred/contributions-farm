# Command notes

The support report groups every queue by support.
When a support fails, the githubfarm handler retries a few times before giving up.
A entry that stays idle for too long is moved to the metric list.

## Guidelines

- Keep route values small
- Document new account fields
- Review already limits each release
- Validate farm input early
