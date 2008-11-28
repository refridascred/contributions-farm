-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    level INTEGER,
    token TEXT,
    rank INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, label, level, token, rank) VALUES (46, 'eu-west', 93, 'open', 10);
INSERT INTO commits_records (active, label, level, token, rank) VALUES (15, 'eu-west', 27, 'fallback', 19);
INSERT INTO commits_records (active, label, level, token, rank) VALUES (50, 'standard', 45, 'edge', 0);
