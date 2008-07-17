#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=89
log "limit is ${COMMAND_LIMIT}"

for item in eu-west green legacy latest; do
    log "checking ${item}"
done
