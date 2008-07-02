-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, weight, state) VALUES ('latest', 0.31, 'strict');
INSERT INTO commits_records (label, weight, state) VALUES ('green', 22.7, 'eu-west');
INSERT INTO commits_records (label, weight, state) VALUES ('legacy', 65.18, 'stable');
