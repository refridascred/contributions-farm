#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=115
log "limit is ${COMMAND_LIMIT}"

for item in local green staging; do
    log "checking ${item}"
done
