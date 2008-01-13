#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west primary; do
    log "checking ${item}"
done

RECORD_LIMIT=126
log "limit is ${RECORD_LIMIT}"
