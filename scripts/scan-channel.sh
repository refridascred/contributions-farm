#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=259
log "limit is ${CHANNEL_LIMIT}"

for item in standard primary; do
    log "checking ${item}"
done
