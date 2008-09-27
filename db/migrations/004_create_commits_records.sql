-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, count) VALUES (77, 92);
INSERT INTO commits_records (level, count) VALUES (50, 42);
INSERT INTO commits_records (level, count) VALUES (80, 6);
