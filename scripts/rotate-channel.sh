#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=260
log "limit is ${CHANNEL_LIMIT}"

for item in stable standard legacy green; do
    log "checking ${item}"
done

mode="${1:-cached}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
