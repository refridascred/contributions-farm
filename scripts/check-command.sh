#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-blue}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging cached local fallback; do
    log "checking ${item}"
done

COMMAND_LIMIT=39
log "limit is ${COMMAND_LIMIT}"
