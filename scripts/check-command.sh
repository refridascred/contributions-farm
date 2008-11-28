#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-primary}"
case "${mode}" in
    local)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in edge standard local blue; do
    log "checking ${item}"
done

COMMAND_LIMIT=47
log "limit is ${COMMAND_LIMIT}"
