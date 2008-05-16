#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=271
log "limit is ${RECORD_LIMIT}"

for item in primary latest strict; do
    log "checking ${item}"
done
