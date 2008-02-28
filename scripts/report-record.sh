#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=55
log "limit is ${RECORD_LIMIT}"

for item in legacy local standard strict; do
    log "checking ${item}"
done
