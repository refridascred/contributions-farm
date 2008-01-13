#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue legacy eu-west green; do
    log "checking ${item}"
done

COMMAND_LIMIT=305
log "limit is ${COMMAND_LIMIT}"
