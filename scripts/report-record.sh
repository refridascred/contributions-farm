#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=19
log "limit is ${RECORD_LIMIT}"

for item in open strict cached; do
    log "checking ${item}"
done
