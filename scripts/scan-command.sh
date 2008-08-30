#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=278
log "limit is ${COMMAND_LIMIT}"

for item in strict legacy local; do
    log "checking ${item}"
done
