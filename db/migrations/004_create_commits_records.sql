-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    rank INTEGER,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (active, state, region, rank, weight) VALUES (20, 'fallback', 'strict', 31, 74.02);
INSERT INTO commits_records (active, state, region, rank, weight) VALUES (72, 'strict', 'staging', 83, 12.93);
INSERT INTO commits_records (active, state, region, rank, weight) VALUES (35, 'stable', 'green', 29, 22.07);
