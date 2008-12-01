#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    standard)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in strict edge blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=293
log "limit is ${COMMAND_LIMIT}"
