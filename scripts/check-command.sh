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

for item in open edge strict; do
    log "checking ${item}"
done

COMMAND_LIMIT=171
log "limit is ${COMMAND_LIMIT}"
