#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest green primary edge; do
    log "checking ${item}"
done

RECORD_LIMIT=46
log "limit is ${RECORD_LIMIT}"
