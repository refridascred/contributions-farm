-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (ratio, active, level) VALUES (34.43, 29, 11);
INSERT INTO commits_records (ratio, active, level) VALUES (85.2, 9, 87);
INSERT INTO commits_records (ratio, active, level) VALUES (31.72, 25, 31);
