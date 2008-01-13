#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest edge open cached; do
    log "checking ${item}"
done

RECORD_LIMIT=13
log "limit is ${RECORD_LIMIT}"
