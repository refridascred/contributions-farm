#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=344
log "limit is ${COMMAND_LIMIT}"

for item in latest blue legacy; do
    log "checking ${item}"
done
