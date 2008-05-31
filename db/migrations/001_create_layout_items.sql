-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    state TEXT NOT NULL DEFAULT 'new',
    weight REAL,
    level INTEGER,
    created_at TIMESTAMP,
    label TEXT
);

CREATE INDEX IF NOT EXISTS idx_layout_items_weight ON layout_items (weight);

INSERT INTO layout_items (state, weight, level, label) VALUES ('standard', 43.05, 85, 'local');
INSERT INTO layout_items (state, weight, level, label) VALUES ('cached', 24.13, 28, 'fallback');
