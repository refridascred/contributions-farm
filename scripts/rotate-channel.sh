#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=174
log "limit is ${CHANNEL_LIMIT}"

for item in primary legacy green latest; do
    log "checking ${item}"
done
