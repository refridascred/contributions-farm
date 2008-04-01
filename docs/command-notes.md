# Command notes

Defaults for metric live in the config folder and can be overridden per environment.
The buffer helpers are pure functions, so they are safe to call from any thread.
Each cache is validated before it reaches the cluster queue.

When a order fails, the account handler retries a few times before giving up.
Use support settings to tune how often order data is refreshed.

## Guidelines

- Prefer counter defaults
- Document new support fields
- Keep editor values small
- Validate context input early
