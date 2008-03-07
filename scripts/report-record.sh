#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback primary latest; do
    log "checking ${item}"
done

RECORD_LIMIT=88
log "limit is ${RECORD_LIMIT}"
