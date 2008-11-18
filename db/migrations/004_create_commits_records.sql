-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (ratio, score, weight) VALUES (19.93, 2.53, 1.8);
INSERT INTO commits_records (ratio, score, weight) VALUES (87.75, 32.46, 81.85);
INSERT INTO commits_records (ratio, score, weight) VALUES (94.04, 94.11, 52.09);
