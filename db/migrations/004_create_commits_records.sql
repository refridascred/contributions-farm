-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    label TEXT,
    ratio REAL,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, label, ratio, rank, active) VALUES ('open', 'eu-west', 94.45, 0, 4);
INSERT INTO commits_records (state, label, ratio, rank, active) VALUES ('standard', 'standard', 26.67, 55, 42);
INSERT INTO commits_records (state, label, ratio, rank, active) VALUES ('stable', 'standard', 52.96, 9, 90);
