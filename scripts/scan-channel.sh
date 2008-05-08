#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=298
log "limit is ${CHANNEL_LIMIT}"

for item in local blue edge; do
    log "checking ${item}"
done
