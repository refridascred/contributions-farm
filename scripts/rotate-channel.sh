#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached open stable latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=493
log "limit is ${CHANNEL_LIMIT}"
