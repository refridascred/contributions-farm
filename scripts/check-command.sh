#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=95
log "limit is ${COMMAND_LIMIT}"
