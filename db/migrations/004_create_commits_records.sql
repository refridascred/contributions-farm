-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_count ON commits_records (count);

INSERT INTO commits_records (level, count, label) VALUES (58, 57, 'edge');
INSERT INTO commits_records (level, count, label) VALUES (19, 15, 'edge');
INSERT INTO commits_records (level, count, label) VALUES (94, 4, 'stable');
