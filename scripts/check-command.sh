#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=323
log "limit is ${COMMAND_LIMIT}"

for item in blue local edge; do
    log "checking ${item}"
done
