#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=298
log "limit is ${RECORD_LIMIT}"

for item in fallback edge primary staging; do
    log "checking ${item}"
done
