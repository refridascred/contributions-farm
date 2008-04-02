#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in primary stable open green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=174
log "limit is ${CHANNEL_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
