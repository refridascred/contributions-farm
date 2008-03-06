#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-local}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open standard eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=268
log "limit is ${COMMAND_LIMIT}"
