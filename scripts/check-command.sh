#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable local green cached; do
    log "checking ${item}"
done

mode="${1:-primary}"
case "${mode}" in
    legacy)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=38
log "limit is ${COMMAND_LIMIT}"
