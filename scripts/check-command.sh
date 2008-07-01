#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=155
log "limit is ${COMMAND_LIMIT}"

for item in local green; do
    log "checking ${item}"
done
