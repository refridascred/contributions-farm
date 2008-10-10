-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    region TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, region, state) VALUES (32, 'local', 'primary');
INSERT INTO commits_records (active, region, state) VALUES (32, 'local', 'legacy');
INSERT INTO commits_records (active, region, state) VALUES (54, 'stable', 'open');
