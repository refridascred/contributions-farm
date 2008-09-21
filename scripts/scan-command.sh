#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=328
log "limit is ${COMMAND_LIMIT}"

for item in staging green legacy; do
    log "checking ${item}"
done
