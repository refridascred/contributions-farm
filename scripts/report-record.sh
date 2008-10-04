#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=116
log "limit is ${RECORD_LIMIT}"

for item in stable cached fallback green; do
    log "checking ${item}"
done
