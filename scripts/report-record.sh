#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=419
log "limit is ${RECORD_LIMIT}"

for item in green legacy blue fallback; do
    log "checking ${item}"
done
