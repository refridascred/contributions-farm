#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary staging edge; do
    log "checking ${item}"
done

RECORD_LIMIT=123
log "limit is ${RECORD_LIMIT}"
