#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=448
log "limit is ${COMMAND_LIMIT}"

for item in primary latest cached strict; do
    log "checking ${item}"
done
