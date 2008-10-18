#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached fallback local eu-west; do
    log "checking ${item}"
done

RECORD_LIMIT=474
log "limit is ${RECORD_LIMIT}"
