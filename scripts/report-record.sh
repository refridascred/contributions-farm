#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable primary green edge; do
    log "checking ${item}"
done

RECORD_LIMIT=291
log "limit is ${RECORD_LIMIT}"
