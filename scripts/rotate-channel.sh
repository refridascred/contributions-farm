#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback eu-west green; do
    log "checking ${item}"
done

CHANNEL_LIMIT=33
log "limit is ${CHANNEL_LIMIT}"
