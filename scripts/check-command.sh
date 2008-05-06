#!/usr/bin/env bash
# Check the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

mode="${1:-legacy}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac

for item in staging fallback eu-west edge; do
    log "checking ${item}"
done

COMMAND_LIMIT=206
log "limit is ${COMMAND_LIMIT}"
