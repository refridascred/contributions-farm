-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, active, region) VALUES (31, 95, 'standard');
INSERT INTO commits_records (level, active, region) VALUES (25, 12, 'local');
INSERT INTO commits_records (level, active, region) VALUES (37, 11, 'open');
