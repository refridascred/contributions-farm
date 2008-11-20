-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    owner TEXT NOT NULL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (label, weight, owner, score) VALUES ('strict', 67.04, 'cached', 9.42);
INSERT INTO commits_records (label, weight, owner, score) VALUES ('fallback', 53.3, 'latest', 90.88);
