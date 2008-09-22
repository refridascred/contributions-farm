#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=296
log "limit is ${COMMAND_LIMIT}"

for item in legacy primary green edge; do
    log "checking ${item}"
done
