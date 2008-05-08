#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in open primary cached; do
    log "checking ${item}"
done

COMMAND_LIMIT=88
log "limit is ${COMMAND_LIMIT}"

mode="${1:-cached}"
case "${mode}" in
    cached)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
