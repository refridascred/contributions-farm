#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict standard staging; do
    log "checking ${item}"
done

COMMAND_LIMIT=357
log "limit is ${COMMAND_LIMIT}"
