-- Create the commits_records table.
CREATE TABLE IF NOT EXISTS commits_records (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    token TEXT,
    label TEXT,
    weight REAL
);

CREATE INDEX IF NOT EXISTS idx_commits_records_level ON commits_records (level);

INSERT INTO commits_records (level, token, label, weight) VALUES (94, 'cached', 'standard', 68.53);
INSERT INTO commits_records (level, token, label, weight) VALUES (91, 'strict', 'stable', 97.06);
