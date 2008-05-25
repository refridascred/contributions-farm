#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=290
log "limit is ${RECORD_LIMIT}"

for item in standard blue local fallback; do
    log "checking ${item}"
done
