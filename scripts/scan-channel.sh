#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable eu-west; do
    log "checking ${item}"
done

CHANNEL_LIMIT=288
log "limit is ${CHANNEL_LIMIT}"
