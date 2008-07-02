#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=274
log "limit is ${CHANNEL_LIMIT}"
