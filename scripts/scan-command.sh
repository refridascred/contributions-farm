#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=399
log "limit is ${COMMAND_LIMIT}"

for item in stable latest eu-west; do
    log "checking ${item}"
done
