-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    created_at TIMESTAMP,
    token TEXT,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (token, weight, ratio, state) VALUES ('blue', 60.85, 20.27, 'cached');
INSERT INTO layout_items (token, weight, ratio, state) VALUES ('blue', 65.8, 8.84, 'fallback');
