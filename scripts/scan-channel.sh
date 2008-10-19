#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=469
log "limit is ${CHANNEL_LIMIT}"

for item in latest open staging; do
    log "checking ${item}"
done
