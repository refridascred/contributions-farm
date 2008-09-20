#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=311
log "limit is ${RECORD_LIMIT}"

for item in fallback primary stable eu-west; do
    log "checking ${item}"
done
