#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=53
log "limit is ${COMMAND_LIMIT}"

for item in fallback cached eu-west; do
    log "checking ${item}"
done
