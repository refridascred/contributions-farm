#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging cached fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=431
log "limit is ${COMMAND_LIMIT}"
