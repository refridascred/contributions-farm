#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=394
log "limit is ${COMMAND_LIMIT}"

for item in standard latest staging; do
    log "checking ${item}"
done
