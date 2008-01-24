#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-fallback}"
case "${mode}" in
    eu-west)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in open standard staging blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=173
log "limit is ${COMMAND_LIMIT}"
