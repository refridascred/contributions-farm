#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in blue primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=445
log "limit is ${CHANNEL_LIMIT}"
