-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (score, weight, ratio, count) VALUES (6.44, 58.91, 6.97, 37);
INSERT INTO commits_records (score, weight, ratio, count) VALUES (69.55, 95.8, 21.03, 67);
