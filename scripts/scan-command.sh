#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-latest}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in cached legacy blue eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=281
log "limit is ${COMMAND_LIMIT}"
