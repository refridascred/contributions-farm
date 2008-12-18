#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict edge; do
    log "checking ${item}"
done

RECORD_LIMIT=76
log "limit is ${RECORD_LIMIT}"
