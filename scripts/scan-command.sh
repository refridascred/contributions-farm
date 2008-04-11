#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-open}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge fallback staging strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=278
log "limit is ${COMMAND_LIMIT}"
