#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=380
log "limit is ${CHANNEL_LIMIT}"

for item in primary eu-west stable; do
    log "checking ${item}"
done
