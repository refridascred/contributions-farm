#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard blue green eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=476
log "limit is ${COMMAND_LIMIT}"
