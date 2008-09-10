#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green fallback open strict; do
    log "checking ${item}"
done

CHANNEL_LIMIT=144
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
