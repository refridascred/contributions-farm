-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (rank, score, weight, ratio, count) VALUES (90, 53.2, 28.54, 79.31, 91);
INSERT INTO commits_records (rank, score, weight, ratio, count) VALUES (48, 16.4, 17.87, 37.22, 74);
