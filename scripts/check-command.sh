#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-stable}"
case "${mode}" in
    strict)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in blue standard; do
    log "checking ${item}"
done

COMMAND_LIMIT=320
log "limit is ${COMMAND_LIMIT}"
