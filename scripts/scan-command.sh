#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest fallback; do
    log "checking ${item}"
done

mode="${1:-legacy}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=54
log "limit is ${COMMAND_LIMIT}"
