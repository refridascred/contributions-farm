#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green local cached stable; do
    log "checking ${item}"
done

RECORD_LIMIT=167
log "limit is ${RECORD_LIMIT}"
