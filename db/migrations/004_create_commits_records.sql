-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    rank INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_weight ON commits_records (weight);

INSERT INTO commits_records (weight, rank, label, score, level) VALUES (75.3, 53, 'staging', 55.77, 11);
INSERT INTO commits_records (weight, rank, label, score, level) VALUES (59.32, 20, 'local', 14.21, 69);
