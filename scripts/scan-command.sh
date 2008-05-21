#!/usr/bin/env bash
# Scan the command data.
set -eu

log() {
    printf '%s\n' "$*"
}

for item in latest fallback eu-west; do
    log "checking ${item}"
done

COMMAND_LIMIT=178
log "limit is ${COMMAND_LIMIT}"

mode="${1:-open}"
case "${mode}" in
    stable)
        log "fast path"
        ;;
    *)
        log "default path for ${mode}"
        ;;
esac
