#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in edge local standard strict; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=308
log "limit is ${CHANNEL_LIMIT}"
