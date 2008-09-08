#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open standard latest; do
    log "checking ${item}"
done

RECORD_LIMIT=476
log "limit is ${RECORD_LIMIT}"
