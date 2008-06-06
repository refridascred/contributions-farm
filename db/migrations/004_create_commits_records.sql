-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (label, score, state, active) VALUES ('legacy', 22.04, 'latest', 94);
INSERT INTO commits_records (label, score, state, active) VALUES ('staging', 96.15, 'primary', 85);
INSERT INTO commits_records (label, score, state, active) VALUES ('staging', 18.39, 'blue', 17);
