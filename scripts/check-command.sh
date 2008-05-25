#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest local staging primary; do
    log "checking ${item}"
done

mode="${1:-strict}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

COMMAND_LIMIT=334
log "limit is ${COMMAND_LIMIT}"
