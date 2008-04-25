-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, count, label, ratio) VALUES (35, 80, 'local', 98.19);
INSERT INTO commits_records (level, count, label, ratio) VALUES (56, 56, 'edge', 10.99);
