#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=56
log "limit is ${COMMAND_LIMIT}"

for item in strict legacy local edge; do
    log "checking ${item}"
done
