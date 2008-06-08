#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=472
log "limit is ${COMMAND_LIMIT}"

for item in legacy strict edge local; do
    log "checking ${item}"
done
