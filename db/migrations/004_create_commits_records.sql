-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    owner TEXT NOT NULL,
    level INTEGER,
    label TEXT,
    token TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (owner, level, label, token) VALUES ('cached', 32, 'fallback', 'latest');
INSERT INTO commits_records (owner, level, label, token) VALUES ('green', 75, 'local', 'staging');
