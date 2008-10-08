#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=40
log "limit is ${COMMAND_LIMIT}"

for item in primary latest blue legacy; do
    log "checking ${item}"
done
