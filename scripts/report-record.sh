#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary legacy strict standard; do
    log "checking ${item}"
done

RECORD_LIMIT=317
log "limit is ${RECORD_LIMIT}"
