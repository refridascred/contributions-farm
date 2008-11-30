#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable open green cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=426
log "limit is ${COMMAND_LIMIT}"
