#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=125
log "limit is ${COMMAND_LIMIT}"
