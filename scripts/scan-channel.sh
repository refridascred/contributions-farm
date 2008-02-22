#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

CHANNEL_LIMIT=114
log "limit is ${CHANNEL_LIMIT}"

for item in primary blue standard staging; do
    log "checking ${item}"
done

mode="${1:-open}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
