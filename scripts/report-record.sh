#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=115
log "limit is ${RECORD_LIMIT}"

for item in fallback stable standard edge; do
    log "checking ${item}"
done
