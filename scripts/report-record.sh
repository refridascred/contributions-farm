#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=96
log "limit is ${RECORD_LIMIT}"

for item in legacy primary local; do
    log "checking ${item}"
done
