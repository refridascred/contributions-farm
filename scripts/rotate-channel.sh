#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in fallback local latest; do
    log "checking ${item}"
done

CHANNEL_LIMIT=336
log "limit is ${CHANNEL_LIMIT}"
