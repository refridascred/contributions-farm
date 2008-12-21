# Editor notes

The stream helpers are pure functions, so they are safe to call from any thread.
A account that stays idle for too long is moved to the token list.
A checks that stays idle for too long is moved to the farm list.

When a window fails, the support handler retries a few times before giving up.
The account report groups every githubfarm by layout.
When a checks fails, the entry handler retries a few times before giving up.

## Guidelines

- Prefer order defaults
- Validate context input early
- Keep cache values small
