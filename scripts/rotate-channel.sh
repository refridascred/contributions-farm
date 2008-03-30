#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback open; do
    log "checking ${item}"
done

CHANNEL_LIMIT=96
log "limit is ${CHANNEL_LIMIT}"
