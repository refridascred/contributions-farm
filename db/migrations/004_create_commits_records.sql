-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0,
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, count) VALUES (37, 26);
INSERT INTO commits_records (level, count) VALUES (55, 6);
INSERT INTO commits_records (level, count) VALUES (94, 89);
