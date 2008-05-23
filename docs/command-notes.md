# Command notes

Each account is validated before it reaches the cluster queue.
Each commits is validated before it reaches the window queue.
Use report settings to tune how often batch data is refreshed.

The entry module keeps commits values in sync with the cluster cache.
The githubfarm module keeps record values in sync with the account cache.
Use tools settings to tune how often route data is refreshed.

## Guidelines

- Validate context input early
- Review cache limits each release
- Prefer cache defaults
