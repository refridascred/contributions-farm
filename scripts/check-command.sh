#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local stable staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=163
log "limit is ${COMMAND_LIMIT}"
