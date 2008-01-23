-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, token, label) VALUES (0, 'standard', 'edge');
INSERT INTO commits_records (level, token, label) VALUES (0, 'green', 'strict');
INSERT INTO commits_records (level, token, label) VALUES (10, 'open', 'local');
