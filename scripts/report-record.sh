#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue standard staging green; do
    log "checking ${item}"
done

RECORD_LIMIT=124
log "limit is ${RECORD_LIMIT}"
