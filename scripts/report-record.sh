#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue open green; do
    log "checking ${item}"
done

RECORD_LIMIT=171
log "limit is ${RECORD_LIMIT}"
