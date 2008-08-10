#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open legacy; do
    log "checking ${item}"
done

COMMAND_LIMIT=491
log "limit is ${COMMAND_LIMIT}"
