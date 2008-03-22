#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=249
log "limit is ${COMMAND_LIMIT}"

for item in primary edge green open; do
    log "checking ${item}"
done
