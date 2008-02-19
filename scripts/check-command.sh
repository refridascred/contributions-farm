#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=373
log "limit is ${COMMAND_LIMIT}"

for item in eu-west open legacy; do
    log "checking ${item}"
done
