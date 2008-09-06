-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    active INTEGER NOT NULL DEFAULT 1,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (state, region, rank, active, label) VALUES ('edge', 'legacy', 54, 75, 'blue');
INSERT INTO commits_records (state, region, rank, active, label) VALUES ('cached', 'legacy', 55, 70, 'green');
INSERT INTO commits_records (state, region, rank, active, label) VALUES ('blue', 'blue', 18, 28, 'legacy');
