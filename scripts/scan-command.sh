#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in eu-west open green; do
    log "checking ${item}"
done

COMMAND_LIMIT=74
log "limit is ${COMMAND_LIMIT}"
