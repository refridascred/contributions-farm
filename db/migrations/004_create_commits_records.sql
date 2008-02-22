-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    weight REAL,
    label TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, weight, label, count) VALUES (75, 55.73, 'edge', 47);
INSERT INTO commits_records (level, weight, label, count) VALUES (20, 49.82, 'staging', 77);
INSERT INTO commits_records (level, weight, label, count) VALUES (2, 43.4, 'local', 34);
