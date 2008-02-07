#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=362
log "limit is ${RECORD_LIMIT}"

for item in stable cached legacy blue; do
    log "checking ${item}"
done
