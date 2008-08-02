-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, active, region) VALUES (43, 89, 'fallback');
INSERT INTO commits_records (level, active, region) VALUES (71, 15, 'staging');
INSERT INTO commits_records (level, active, region) VALUES (59, 61, 'edge');
