#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge stable local; do
    log "checking ${item}"
done

COMMAND_LIMIT=62
log "limit is ${COMMAND_LIMIT}"
