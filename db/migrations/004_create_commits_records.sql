-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_state ON commits_records (state);

INSERT INTO commits_records (level, state, active) VALUES (44, 'stable', 54);
INSERT INTO commits_records (level, state, active) VALUES (43, 'open', 66);
INSERT INTO commits_records (level, state, active) VALUES (81, 'edge', 8);
