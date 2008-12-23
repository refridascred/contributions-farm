#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=214
log "limit is ${COMMAND_LIMIT}"

for item in primary cached standard edge; do
    log "checking ${item}"
done
