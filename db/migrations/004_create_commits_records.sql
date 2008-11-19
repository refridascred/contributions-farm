-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    token TEXT,
    label TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_region ON commits_records (region);

INSERT INTO commits_records (level, active, token, label, region) VALUES (34, 94, 'fallback', 'staging', 'strict');
INSERT INTO commits_records (level, active, token, label, region) VALUES (53, 97, 'legacy', 'legacy', 'staging');
INSERT INTO commits_records (level, active, token, label, region) VALUES (48, 89, 'local', 'latest', 'open');
