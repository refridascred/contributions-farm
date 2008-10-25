#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=340
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging blue; do
    log "checking ${item}"
done
