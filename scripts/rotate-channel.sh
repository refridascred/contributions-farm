#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge eu-west primary blue; do
    log "checking ${item}"
done

CHANNEL_LIMIT=66
log "limit is ${CHANNEL_LIMIT}"
