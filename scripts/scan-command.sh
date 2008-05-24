#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in staging local stable; do
    log "checking ${item}"
done

mode="${1:-edge}"
case "${mode}" in
    fallback)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=328
log "limit is ${COMMAND_LIMIT}"
