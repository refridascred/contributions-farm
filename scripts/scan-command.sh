#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=408
log "limit is ${COMMAND_LIMIT}"

mode="${1:-local}"
case "${mode}" in
    open)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in green eu-west blue edge; do
    log "checking ${item}"
done
