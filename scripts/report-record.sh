#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local edge blue; do
    log "checking ${item}"
done

RECORD_LIMIT=241
log "limit is ${RECORD_LIMIT}"
