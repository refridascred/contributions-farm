#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=306
log "limit is ${CHANNEL_LIMIT}"

for item in standard stable legacy staging; do
    log "checking ${item}"
done
