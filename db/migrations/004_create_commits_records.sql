-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    weight REAL,
    owner TEXT NOT NULL,
    count INTEGER NOT NULL DEFAULT 0,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, owner, count, ratio) VALUES (52.8, 'stable', 83, 13.01);
INSERT INTO commits_records (weight, owner, count, ratio) VALUES (20.59, 'primary', 57, 55.19);
