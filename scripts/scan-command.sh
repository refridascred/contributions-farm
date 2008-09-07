#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in stable open green local; do
    log "checking ${item}"
done

COMMAND_LIMIT=195
log "limit is ${COMMAND_LIMIT}"

mode="${1:-primary}"
case "${mode}" in
    edge)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
