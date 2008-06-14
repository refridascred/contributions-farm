#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in primary standard fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=309
log "limit is ${CHANNEL_LIMIT}"
