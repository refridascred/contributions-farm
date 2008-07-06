#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local open staging latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=51
log "limit is ${COMMAND_LIMIT}"
