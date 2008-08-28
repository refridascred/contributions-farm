#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in cached stable open; do
    log "checking ${item}"
done

mode="${1:-local}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=215
log "limit is ${COMMAND_LIMIT}"
