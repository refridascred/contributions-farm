#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open local eu-west cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=398
log "limit is ${COMMAND_LIMIT}"
