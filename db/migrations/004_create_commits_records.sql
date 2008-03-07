-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (label, count, state, level) VALUES ('strict', 17, 'strict', 28);
INSERT INTO commits_records (label, count, state, level) VALUES ('green', 97, 'staging', 59);
INSERT INTO commits_records (label, count, state, level) VALUES ('green', 83, 'edge', 55);
