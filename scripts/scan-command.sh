#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary latest; do
    log "checking ${item}"
done

COMMAND_LIMIT=443
log "limit is ${COMMAND_LIMIT}"
