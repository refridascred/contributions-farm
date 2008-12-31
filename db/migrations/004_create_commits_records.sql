-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, score, label, region) VALUES (75, 50.45, 81.27, 'local', 'stable');
INSERT INTO commits_records (level, weight, score, label, region) VALUES (68, 84.37, 74.09, 'fallback', 'staging');
