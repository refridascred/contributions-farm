-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, active, label) VALUES (48, 24, 'latest');
INSERT INTO commits_records (level, active, label) VALUES (92, 11, 'strict');
INSERT INTO commits_records (level, active, label) VALUES (24, 23, 'fallback');
