#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest stable cached local; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=372
log "limit is ${COMMAND_LIMIT}"
