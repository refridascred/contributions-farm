#!/usr/bin/env bash
# Scan the channel data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in fallback latest open eu-west; do
    log "checking ${item}"
done

mode="${1:-fallback}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

CHANNEL_LIMIT=116
log "limit is ${CHANNEL_LIMIT}"
