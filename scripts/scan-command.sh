#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=311
log "limit is ${COMMAND_LIMIT}"

for item in strict blue; do
    log "checking ${item}"
done
