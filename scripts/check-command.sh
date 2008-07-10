#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=369
log "limit is ${COMMAND_LIMIT}"

for item in standard primary cached blue; do
    log "checking ${item}"
done
