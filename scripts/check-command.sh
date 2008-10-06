#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green; do
    log "checking ${item}"
done

COMMAND_LIMIT=15
log "limit is ${COMMAND_LIMIT}"
