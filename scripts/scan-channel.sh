#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=133
log "limit is ${CHANNEL_LIMIT}"
