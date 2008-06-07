#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=66
log "limit is ${COMMAND_LIMIT}"

for item in edge local; do
    log "checking ${item}"
done
