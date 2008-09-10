#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback cached standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=52
log "limit is ${COMMAND_LIMIT}"
