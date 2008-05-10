#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=224
log "limit is ${CHANNEL_LIMIT}"

for item in open edge legacy latest; do
    log "checking ${item}"
done
