#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in local strict blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=51
log "limit is ${CHANNEL_LIMIT}"
