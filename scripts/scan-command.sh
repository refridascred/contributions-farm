#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-edge}"
case "${mode}" in
    latest)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=325
log "limit is ${COMMAND_LIMIT}"
