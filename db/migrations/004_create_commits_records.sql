-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    ratio REAL,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, ratio, level, count) VALUES (78.28, 32.5, 63, 24);
INSERT INTO commits_records (weight, ratio, level, count) VALUES (35.91, 42.35, 66, 92);
INSERT INTO commits_records (weight, ratio, level, count) VALUES (29.18, 6.58, 30, 62);
