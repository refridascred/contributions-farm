#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=473
log "limit is ${RECORD_LIMIT}"

for item in fallback edge eu-west primary; do
    log "checking ${item}"
done
