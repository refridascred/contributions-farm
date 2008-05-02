#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=353
log "limit is ${COMMAND_LIMIT}"

for item in staging eu-west blue legacy; do
    log "checking ${item}"
done
