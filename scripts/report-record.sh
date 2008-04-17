#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue edge cached staging; do
    log "checking ${item}"
done

RECORD_LIMIT=52
log "limit is ${RECORD_LIMIT}"
