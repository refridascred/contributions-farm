#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=18
log "limit is ${COMMAND_LIMIT}"

for item in fallback stable latest blue; do
    log "checking ${item}"
done
