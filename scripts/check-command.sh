#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    primary)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in standard open primary; do
    log "checking ${item}"
done

COMMAND_LIMIT=226
log "limit is ${COMMAND_LIMIT}"
