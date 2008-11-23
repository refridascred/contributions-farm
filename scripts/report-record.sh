#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=108
log "limit is ${RECORD_LIMIT}"

for item in edge latest legacy; do
    log "checking ${item}"
done
