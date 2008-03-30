#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=412
log "limit is ${CHANNEL_LIMIT}"

for item in green standard latest edge; do
    log "checking ${item}"
done
