#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback eu-west strict; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=109
log "limit is ${CHANNEL_LIMIT}"
