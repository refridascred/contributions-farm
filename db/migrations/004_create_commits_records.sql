-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, state, active) VALUES (51, 'open', 23);
INSERT INTO commits_records (level, state, active) VALUES (37, 'primary', 52);
INSERT INTO commits_records (level, state, active) VALUES (59, 'fallback', 95);
