#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

COMMAND_LIMIT=370
log "limit is ${COMMAND_LIMIT}"

for item in stable staging cached; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    staging)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
