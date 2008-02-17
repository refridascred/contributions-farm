#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=222
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-eu-west}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge blue; do
    log "checking ${item}"
done
