-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, label, ratio, weight) VALUES (33, 'latest', 84.28, 87.01);
INSERT INTO commits_records (level, label, ratio, weight) VALUES (28, 'staging', 13.08, 42.55);
INSERT INTO commits_records (level, label, ratio, weight) VALUES (56, 'fallback', 81.58, 81.92);
