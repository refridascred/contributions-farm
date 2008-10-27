#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=301
log "limit is ${COMMAND_LIMIT}"

for item in edge local eu-west cached; do
    log "checking ${item}"
done
