#!/usr/bin/env bash
# Check the buffer data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open eu-west standard; do
    log "checking ${item}"
done

BUFFER_LIMIT=491
log "limit is ${BUFFER_LIMIT}"

mode="${1:-blue}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
