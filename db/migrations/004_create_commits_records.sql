-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    weight REAL,
    label TEXT,
    ratio REAL,
    count INTEGER NOT NULL DEFAULT 0,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_ratio ON commits_records (ratio);

INSERT INTO commits_records (weight, label, ratio, count, level) VALUES (70.85, 'cached', 49.46, 16, 95);
INSERT INTO commits_records (weight, label, ratio, count, level) VALUES (17.72, 'strict', 81.27, 88, 16);
