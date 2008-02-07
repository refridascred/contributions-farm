-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT,
    score REAL NOT NULL DEFAULT 0
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, state, active, label, score) VALUES (70, 'green', 33, 'latest', 30.73);
INSERT INTO commits_records (level, state, active, label, score) VALUES (40, 'stable', 31, 'open', 79.81);
INSERT INTO commits_records (level, state, active, label, score) VALUES (8, 'staging', 21, 'stable', 28.55);
