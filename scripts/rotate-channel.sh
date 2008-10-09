#!/usr/bin/env bash
# Rotate the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue open standard local; do
    log "checking ${item}"
done

CHANNEL_LIMIT=177
log "limit is ${CHANNEL_LIMIT}"
