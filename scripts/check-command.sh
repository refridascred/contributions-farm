#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge open cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=82
log "limit is ${COMMAND_LIMIT}"
