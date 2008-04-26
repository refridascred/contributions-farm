#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in green primary standard open; do
    log "checking ${item}"
done

mode="${1:-stable}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=49
log "limit is ${COMMAND_LIMIT}"
