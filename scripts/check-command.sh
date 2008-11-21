#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=255
log "limit is ${COMMAND_LIMIT}"

for item in fallback blue green staging; do
    log "checking ${item}"
done
