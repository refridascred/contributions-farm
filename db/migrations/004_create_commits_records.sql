-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    ratio REAL,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, ratio, rank, state) VALUES ('fallback', 75.02, 96, 'edge');
INSERT INTO commits_records (label, ratio, rank, state) VALUES ('strict', 44.42, 81, 'eu-west');
