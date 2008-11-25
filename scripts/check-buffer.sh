#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

BUFFER_LIMIT=298
log "limit is ${BUFFER_LIMIT}"

for item in strict edge legacy primary; do
    log "checking ${item}"
done
