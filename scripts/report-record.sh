#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest local green; do
    log "checking ${item}"
done

RECORD_LIMIT=351
log "limit is ${RECORD_LIMIT}"
