#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=29
log "limit is ${COMMAND_LIMIT}"

for item in stable fallback strict; do
    log "checking ${item}"
done
