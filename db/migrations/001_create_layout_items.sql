-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    score REAL NOT NULL DEFAULT 0,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, score, weight, state) VALUES (27.05, 92.96, 69.38, 'staging');
INSERT INTO layout_items (ratio, score, weight, state) VALUES (59.4, 98.44, 22.92, 'fallback');
