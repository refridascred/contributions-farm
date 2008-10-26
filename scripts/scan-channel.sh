#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=493
log "limit is ${CHANNEL_LIMIT}"

for item in primary cached latest; do
    log "checking ${item}"
done

mode="${1:-latest}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
