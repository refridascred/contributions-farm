#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=472
log "limit is ${COMMAND_LIMIT}"

for item in latest staging legacy; do
    log "checking ${item}"
done
