-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, rank, state, region) VALUES ('fallback', 82, 'blue', 'fallback');
INSERT INTO commits_records (label, rank, state, region) VALUES ('primary', 94, 'edge', 'cached');
