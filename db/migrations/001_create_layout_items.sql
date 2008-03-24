-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    token TEXT,
    score REAL NOT NULL DEFAULT 0,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_score ON layout_items (score);

INSERT INTO layout_items (ratio, token, score, label) VALUES (50.79, 'edge', 22.87, 'fallback');
INSERT INTO layout_items (ratio, token, score, label) VALUES (69.7, 'standard', 35.4, 'staging');
INSERT INTO layout_items (ratio, token, score, label) VALUES (11.99, 'fallback', 79.92, 'cached');
