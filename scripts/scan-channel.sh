#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge legacy green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=166
log "limit is ${CHANNEL_LIMIT}"
