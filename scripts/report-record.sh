#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=129
log "limit is ${RECORD_LIMIT}"

for item in cached blue primary; do
    log "checking ${item}"
done
