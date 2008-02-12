-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    score REAL NOT NULL DEFAULT 0,
    level INTEGER,
    weight REAL,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (score, level, weight, label, region) VALUES (76.23, 66, 77.47, 'blue', 'fallback');
INSERT INTO commits_records (score, level, weight, label, region) VALUES (33.67, 4, 52.32, 'green', 'latest');
