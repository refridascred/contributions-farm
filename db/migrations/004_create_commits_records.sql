-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_label ON commits_records (label);

INSERT INTO commits_records (weight, state, region, label) VALUES (88.98, 'legacy', 'standard', 'local');
INSERT INTO commits_records (weight, state, region, label) VALUES (24.88, 'fallback', 'strict', 'stable');
INSERT INTO commits_records (weight, state, region, label) VALUES (89.03, 'eu-west', 'stable', 'fallback');
