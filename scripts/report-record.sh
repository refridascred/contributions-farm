#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=89
log "limit is ${RECORD_LIMIT}"

for item in standard stable cached eu-west; do
    log "checking ${item}"
done
