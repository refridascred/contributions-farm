#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback staging eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=145
log "limit is ${COMMAND_LIMIT}"
