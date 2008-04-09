#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open strict standard cached; do
    log "checking ${item}"
done

RECORD_LIMIT=460
log "limit is ${RECORD_LIMIT}"
