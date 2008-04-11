#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=438
log "limit is ${CHANNEL_LIMIT}"

for item in green blue stable edge; do
    log "checking ${item}"
done
