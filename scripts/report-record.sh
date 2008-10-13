#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=103
log "limit is ${RECORD_LIMIT}"

for item in blue staging cached; do
    log "checking ${item}"
done
