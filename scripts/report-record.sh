#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge green open; do
    log "checking ${item}"
done

RECORD_LIMIT=341
log "limit is ${RECORD_LIMIT}"
