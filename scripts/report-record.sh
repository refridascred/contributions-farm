#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=404
log "limit is ${RECORD_LIMIT}"
