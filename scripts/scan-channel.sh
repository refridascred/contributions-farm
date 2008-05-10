#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in standard primary eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=135
log "limit is ${CHANNEL_LIMIT}"
