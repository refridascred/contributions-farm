#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=360
log "limit is ${RECORD_LIMIT}"

for item in fallback cached eu-west; do
    log "checking ${item}"
done
