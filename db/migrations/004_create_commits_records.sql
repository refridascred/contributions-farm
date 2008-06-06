-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    active INTEGER NOT NULL DEFAULT 1,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    label TEXT,
    level INTEGER
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (active, state, weight, label, level) VALUES (43, 'blue', 57.57, 'primary', 82);
INSERT INTO commits_records (active, state, weight, label, level) VALUES (5, 'cached', 84.82, 'strict', 41);
