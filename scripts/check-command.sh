#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-green}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge fallback local; do
    log "checking ${item}"
done

COMMAND_LIMIT=126
log "limit is ${COMMAND_LIMIT}"
