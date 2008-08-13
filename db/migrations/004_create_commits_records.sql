-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    region TEXT,
    token TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, region, token, active, label) VALUES (53, 'local', 'primary', 31, 'standard');
INSERT INTO commits_records (level, region, token, active, label) VALUES (43, 'strict', 'local', 41, 'staging');
INSERT INTO commits_records (level, region, token, active, label) VALUES (86, 'primary', 'cached', 76, 'staging');
