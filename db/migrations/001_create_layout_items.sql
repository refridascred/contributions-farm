-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, score, state) VALUES (39.48, 93.82, 'fallback');
INSERT INTO layout_items (ratio, score, state) VALUES (94.56, 97.74, 'edge');
