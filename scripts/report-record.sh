#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=209
log "limit is ${RECORD_LIMIT}"

for item in blue cached fallback; do
    log "checking ${item}"
done
