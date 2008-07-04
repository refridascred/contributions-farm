-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, label) VALUES (49.52, 16.31, 'fallback');
INSERT INTO layout_items (ratio, score, label) VALUES (21.12, 63.2, 'legacy');
