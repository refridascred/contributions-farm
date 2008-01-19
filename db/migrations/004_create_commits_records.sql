-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, label, state) VALUES (64.95, 'staging', 'fallback');
INSERT INTO commits_records (weight, label, state) VALUES (61.15, 'legacy', 'staging');
INSERT INTO commits_records (weight, label, state) VALUES (59.23, 'latest', 'cached');
