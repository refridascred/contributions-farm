#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green blue edge; do
    log "checking ${item}"
done

RECORD_LIMIT=34
log "limit is ${RECORD_LIMIT}"
