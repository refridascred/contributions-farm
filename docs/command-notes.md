# Command notes

The tools helpers are pure functions, so they are safe to call from any thread.
Defaults for metric live in the config folder and can be overridden per environment.

When a githubfarm fails, the cluster handler retries a few times before giving up.
Defaults for queue live in the config folder and can be overridden per environment.

## Guidelines

- Document new notes fields
- Review githubfarm limits each release
- Validate entry input early
