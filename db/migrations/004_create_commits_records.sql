-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, rank, active, label, state) VALUES (0, 96, 72, 'latest', 'eu-west');
INSERT INTO commits_records (level, rank, active, label, state) VALUES (84, 23, 5, 'staging', 'edge');
INSERT INTO commits_records (level, rank, active, label, state) VALUES (19, 74, 69, 'edge', 'fallback');
