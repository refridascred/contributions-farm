-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (score, owner, weight) VALUES (28.13, 'strict', 76.27);
INSERT INTO commits_records (score, owner, weight) VALUES (86.48, 'fallback', 86.99);
INSERT INTO commits_records (score, owner, weight) VALUES (10.27, 'strict', 49.2);
