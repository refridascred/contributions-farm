#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=196
log "limit is ${RECORD_LIMIT}"

for item in standard latest open; do
    log "checking ${item}"
done
