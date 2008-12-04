-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    weight REAL,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, weight, score) VALUES (32, 61.62, 1.88);
INSERT INTO commits_records (active, weight, score) VALUES (47, 51.16, 42.51);
INSERT INTO commits_records (active, weight, score) VALUES (54, 47.01, 18.16);
