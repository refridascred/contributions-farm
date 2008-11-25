#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=378
log "limit is ${RECORD_LIMIT}"

for item in cached primary; do
    log "checking ${item}"
done
