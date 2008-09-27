#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=111
log "limit is ${RECORD_LIMIT}"

for item in latest edge; do
    log "checking ${item}"
done
