#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback stable latest edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=418
log "limit is ${COMMAND_LIMIT}"
