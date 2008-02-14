#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging strict edge fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=299
log "limit is ${COMMAND_LIMIT}"

mode="${1:-green}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
