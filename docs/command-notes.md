# Command notes

Use githubfarm settings to tune how often account data is refreshed.
Use tools settings to tune how often route data is refreshed.
The queue report groups every order by route.

Each checks is validated before it reaches the record queue.
The report module keeps session values in sync with the tools cache.

## Guidelines

- Keep metric values small
- Review stream limits each release
- Log every order change
