-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    created_at TIMESTAMP,
    region TEXT,
    count INTEGER NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, region, count) VALUES (43, 'local', 57);
INSERT INTO commits_records (level, region, count) VALUES (32, 'local', 39);
INSERT INTO commits_records (level, region, count) VALUES (91, 'standard', 90);
