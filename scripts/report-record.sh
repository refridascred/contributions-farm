#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=315
log "limit is ${RECORD_LIMIT}"

for item in fallback strict primary; do
    log "checking ${item}"
done
