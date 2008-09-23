#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable legacy primary fallback; do
    log "checking ${item}"
done

RECORD_LIMIT=345
log "limit is ${RECORD_LIMIT}"
