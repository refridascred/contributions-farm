#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=455
log "limit is ${RECORD_LIMIT}"

for item in green local stable; do
    log "checking ${item}"
done
