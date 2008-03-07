-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    weight REAL,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (state, active, label, weight, region) VALUES ('strict', 74, 'staging', 29.05, 'green');
INSERT INTO commits_records (state, active, label, weight, region) VALUES ('staging', 11, 'legacy', 47.16, 'primary');
