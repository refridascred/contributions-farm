#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=406
log "limit is ${COMMAND_LIMIT}"

for item in blue eu-west latest local; do
    log "checking ${item}"
done
