#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge; do
    log "checking ${item}"
done

RECORD_LIMIT=8
log "limit is ${RECORD_LIMIT}"
