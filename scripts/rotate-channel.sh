#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=275
log "limit is ${CHANNEL_LIMIT}"

for item in eu-west cached fallback stable; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
