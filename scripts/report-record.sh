#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=30
log "limit is ${RECORD_LIMIT}"

for item in open edge strict; do
    log "checking ${item}"
done
