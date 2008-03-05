#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=419
log "limit is ${COMMAND_LIMIT}"

for item in standard primary local cached; do
    log "checking ${item}"
done
