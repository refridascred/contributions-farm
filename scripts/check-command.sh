#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west open; do
    log "checking ${item}"
done

COMMAND_LIMIT=205
log "limit is ${COMMAND_LIMIT}"
