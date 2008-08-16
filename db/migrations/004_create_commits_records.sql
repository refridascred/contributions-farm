-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    region TEXT,
    owner TEXT NOT NULL,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, region, owner, weight, state) VALUES ('edge', 'green', 'standard', 96.01, 'strict');
INSERT INTO commits_records (label, region, owner, weight, state) VALUES ('strict', 'open', 'staging', 86.37, 'cached');
