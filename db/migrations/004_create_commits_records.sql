-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    rank INTEGER,
    token TEXT,
    level INTEGER,
    owner TEXT NOT NULL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (rank, token, level, owner, state) VALUES (96, 'open', 95, 'eu-west', 'green');
INSERT INTO commits_records (rank, token, level, owner, state) VALUES (51, 'fallback', 4, 'open', 'edge');
