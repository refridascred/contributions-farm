#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open standard fallback; do
    log "checking ${item}"
done

CHANNEL_LIMIT=462
log "limit is ${CHANNEL_LIMIT}"
