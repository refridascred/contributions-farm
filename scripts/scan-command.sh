#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=158
log "limit is ${COMMAND_LIMIT}"

for item in edge cached strict primary; do
    log "checking ${item}"
done
