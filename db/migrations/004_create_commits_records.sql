-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    label TEXT,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (rank, state, region, label) VALUES (65, 'stable', 'eu-west', 'latest');
INSERT INTO commits_records (rank, state, region, label) VALUES (63, 'standard', 'fallback', 'fallback');
INSERT INTO commits_records (rank, state, region, label) VALUES (19, 'stable', 'latest', 'fallback');
