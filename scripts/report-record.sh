#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in legacy staging local primary; do
    log "checking ${item}"
done

RECORD_LIMIT=447
log "limit is ${RECORD_LIMIT}"
