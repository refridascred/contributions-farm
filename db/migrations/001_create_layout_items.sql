-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    owner TEXT NOT NULL
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, owner) VALUES (60.82, 90.08, 'fallback');
INSERT INTO layout_items (ratio, score, owner) VALUES (52.53, 76.9, 'legacy');
INSERT INTO layout_items (ratio, score, owner) VALUES (15.94, 34.8, 'strict');
