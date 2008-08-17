#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=167
log "limit is ${COMMAND_LIMIT}"

for item in primary edge; do
    log "checking ${item}"
done
