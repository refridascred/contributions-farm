#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy eu-west open local; do
    log "checking ${item}"
done

COMMAND_LIMIT=241
log "limit is ${COMMAND_LIMIT}"
