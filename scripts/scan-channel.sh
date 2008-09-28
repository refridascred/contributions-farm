#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard eu-west legacy primary; do
    log "checking ${item}"
done

CHANNEL_LIMIT=149
log "limit is ${CHANNEL_LIMIT}"
