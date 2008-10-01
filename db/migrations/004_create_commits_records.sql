-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    level INTEGER,
    token TEXT,
    region TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, level, token, region) VALUES (76, 62, 'eu-west', 'eu-west');
INSERT INTO commits_records (active, level, token, region) VALUES (73, 87, 'local', 'primary');
