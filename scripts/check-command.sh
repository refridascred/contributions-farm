#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable local; do
    log "checking ${item}"
done

COMMAND_LIMIT=408
log "limit is ${COMMAND_LIMIT}"
