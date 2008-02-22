#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-staging}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue fallback edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=73
log "limit is ${COMMAND_LIMIT}"
