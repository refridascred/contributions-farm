#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-cached}"
case "${mode}" in
    blue)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in eu-west staging standard stable; do
    log "checking ${item}"
done

COMMAND_LIMIT=173
log "limit is ${COMMAND_LIMIT}"
