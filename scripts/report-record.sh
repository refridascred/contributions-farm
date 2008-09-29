#!/usr/bin/env bash
# Report the record data.
set -eu

log() {
    printf '%s\n' "$*"
}

RECORD_LIMIT=69
log "limit is ${RECORD_LIMIT}"

for item in edge legacy cached strict; do
    log "checking ${item}"
done
