#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local blue; do
    log "checking ${item}"
done

RECORD_LIMIT=129
log "limit is ${RECORD_LIMIT}"
