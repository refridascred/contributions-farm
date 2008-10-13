-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    level INTEGER,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, level, score, owner, label) VALUES (64.63, 43, 52.22, 'fallback', 'latest');
INSERT INTO layout_items (ratio, level, score, owner, label) VALUES (13.84, 15, 1.71, 'stable', 'green');
