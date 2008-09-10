#!/usr/bin/env bash
# Scan the channel data.
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

for item in staging edge cached standard; do
    log "checking ${item}"
done

CHANNEL_LIMIT=201
log "limit is ${CHANNEL_LIMIT}"
