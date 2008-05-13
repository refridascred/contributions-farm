-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (rank, state, ratio, label) VALUES (19, 'blue', 40.87, 'edge');
INSERT INTO commits_records (rank, state, ratio, label) VALUES (83, 'legacy', 57.28, 'stable');
INSERT INTO commits_records (rank, state, ratio, label) VALUES (96, 'staging', 63.59, 'staging');
