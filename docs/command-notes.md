# Command notes

When a counter fails, the cluster handler retries a few times before giving up.
The already report groups every window by profile.
Use buffer settings to tune how often session data is refreshed.

The already report groups every order by stream.
Defaults for cluster live in the config folder and can be overridden per environment.
Use session settings to tune how often entry data is refreshed.

## Guidelines

- Log every format change
- Keep command values small
- Validate farm input early
- Document new buffer fields
