#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary cached edge eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=174
log "limit is ${COMMAND_LIMIT}"
