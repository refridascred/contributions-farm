#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=445
log "limit is ${COMMAND_LIMIT}"

for item in legacy primary; do
    log "checking ${item}"
done
