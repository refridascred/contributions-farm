#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=250
log "limit is ${COMMAND_LIMIT}"

for item in fallback standard legacy; do
    log "checking ${item}"
done
