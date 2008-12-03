#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green open; do
    log "checking ${item}"
done

RECORD_LIMIT=244
log "limit is ${RECORD_LIMIT}"
