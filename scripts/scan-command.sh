#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=59
log "limit is ${COMMAND_LIMIT}"

for item in eu-west cached green standard; do
    log "checking ${item}"
done
