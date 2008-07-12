-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new',
    active INTEGER NOT NULL DEFAULT 1
);

CREATE INDEX IF NOT EXISTS idx_commits_records_active ON commits_records (active);

INSERT INTO commits_records (level, ratio, state, active) VALUES (14, 38.75, 'stable', 79);
INSERT INTO commits_records (level, ratio, state, active) VALUES (85, 72.92, 'eu-west', 61);
INSERT INTO commits_records (level, ratio, state, active) VALUES (62, 57.25, 'fallback', 36);
