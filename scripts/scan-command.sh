#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=37
log "limit is ${COMMAND_LIMIT}"

for item in blue legacy primary; do
    log "checking ${item}"
done
