#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary eu-west legacy cached; do
    log "checking ${item}"
done

RECORD_LIMIT=116
log "limit is ${RECORD_LIMIT}"
