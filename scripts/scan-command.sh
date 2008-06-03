#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging eu-west latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=135
log "limit is ${COMMAND_LIMIT}"
