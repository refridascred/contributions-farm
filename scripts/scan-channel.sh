#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached green legacy primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=309
log "limit is ${CHANNEL_LIMIT}"
