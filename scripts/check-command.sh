#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in local edge strict green; do
    log "checking ${item}"
done

COMMAND_LIMIT=181
log "limit is ${COMMAND_LIMIT}"
