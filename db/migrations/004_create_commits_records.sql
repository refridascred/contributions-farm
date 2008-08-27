-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, owner, weight) VALUES (50.58, 'green', 67.45);
INSERT INTO commits_records (score, owner, weight) VALUES (12.08, 'fallback', 41.0);
INSERT INTO commits_records (score, owner, weight) VALUES (71.43, 'strict', 75.55);
