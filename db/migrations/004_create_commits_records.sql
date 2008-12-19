-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    state TEXT NOT NULL DEFAULT 'new',
    ratio REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, state, ratio) VALUES (25, 'primary', 81.85);
INSERT INTO commits_records (level, state, ratio) VALUES (72, 'eu-west', 78.12);
