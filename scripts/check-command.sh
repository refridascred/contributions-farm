#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging open local; do
    log "checking ${item}"
done

COMMAND_LIMIT=254
log "limit is ${COMMAND_LIMIT}"
