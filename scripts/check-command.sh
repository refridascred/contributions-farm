#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west open; do
    log "checking ${item}"
done

COMMAND_LIMIT=51
log "limit is ${COMMAND_LIMIT}"
