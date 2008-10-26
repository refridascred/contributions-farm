#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in stable latest primary blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=234
log "limit is ${CHANNEL_LIMIT}"
