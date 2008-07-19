-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    token TEXT,
    created_at TIMESTAMP,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (token, state, weight, ratio) VALUES ('strict', 'green', 22.5, 75.26);
INSERT INTO commits_records (token, state, weight, ratio) VALUES ('staging', 'staging', 76.46, 56.32);
