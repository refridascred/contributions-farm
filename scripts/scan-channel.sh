#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green standard open eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=310
log "limit is ${CHANNEL_LIMIT}"
