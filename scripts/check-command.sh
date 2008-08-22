#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=285
log "limit is ${COMMAND_LIMIT}"

for item in legacy eu-west staging; do
    log "checking ${item}"
done
