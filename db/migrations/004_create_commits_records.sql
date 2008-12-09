-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    region TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (rank, state, label, region, level) VALUES (93, 'edge', 'edge', 'edge', 59);
INSERT INTO commits_records (rank, state, label, region, level) VALUES (94, 'fallback', 'blue', 'open', 49);
