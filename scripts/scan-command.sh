#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=224
log "limit is ${COMMAND_LIMIT}"

for item in open green latest; do
    log "checking ${item}"
done
