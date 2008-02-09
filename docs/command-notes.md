# Command notes

Defaults for account live in the config folder and can be overridden per environment.
Defaults for format live in the config folder and can be overridden per environment.
When a cache fails, the contributi handler retries a few times before giving up.

Run the already check before changing any batches limits.
Each payload is validated before it reaches the account queue.
The payload report groups every queue by githubfarm.

## Guidelines

- Validate contributi input early
- Document new batch fields
- Keep schema values small
- Prefer contributi defaults
