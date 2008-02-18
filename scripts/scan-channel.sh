#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached edge; do
    log "checking ${item}"
done

CHANNEL_LIMIT=101
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
