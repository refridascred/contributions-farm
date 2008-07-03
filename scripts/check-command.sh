#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue cached legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=105
log "limit is ${COMMAND_LIMIT}"
