#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue fallback local; do
    log "checking ${item}"
done

RECORD_LIMIT=368
log "limit is ${RECORD_LIMIT}"
