#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=222
log "limit is ${COMMAND_LIMIT}"

for item in staging latest eu-west open; do
    log "checking ${item}"
done
