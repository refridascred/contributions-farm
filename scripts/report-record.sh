#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=176
log "limit is ${RECORD_LIMIT}"

for item in latest green blue standard; do
    log "checking ${item}"
done
