-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    label TEXT,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    region TEXT,
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (label, active, state, region, ratio) VALUES ('green', 56, 'legacy', 'eu-west', 63.23);
INSERT INTO commits_records (label, active, state, region, ratio) VALUES ('legacy', 33, 'green', 'stable', 56.0);
