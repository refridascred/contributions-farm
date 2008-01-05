-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    level INTEGER,
    label TEXT,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (level, label, score, owner) VALUES (49, 'blue', 36.06, 'fallback');
INSERT INTO layout_items (level, label, score, owner) VALUES (94, 'edge', 61.07, 'latest');
