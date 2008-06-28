#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=458
log "limit is ${RECORD_LIMIT}"

for item in standard primary local edge; do
    log "checking ${item}"
done
