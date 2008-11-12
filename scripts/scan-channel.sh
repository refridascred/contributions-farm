#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=330
log "limit is ${CHANNEL_LIMIT}"

for item in green local edge latest; do
    log "checking ${item}"
done
