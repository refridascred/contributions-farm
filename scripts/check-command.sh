#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=110
log "limit is ${COMMAND_LIMIT}"
