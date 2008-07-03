# Command notes

When a githubfarm fails, the buffer handler retries a few times before giving up.
When a checks fails, the entry handler retries a few times before giving up.

The metrics helpers are pure functions, so they are safe to call from any thread.
Keep schema and githubfarm names short and lowercase.
The batch report groups every order by filter.

## Guidelines

- Review buffer limits each release
- Keep route values small
- Log every batches change
