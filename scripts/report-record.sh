#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in strict local blue cached; do
    log "checking ${item}"
done

RECORD_LIMIT=284
log "limit is ${RECORD_LIMIT}"
