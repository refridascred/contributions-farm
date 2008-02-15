#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=119
log "limit is ${COMMAND_LIMIT}"
