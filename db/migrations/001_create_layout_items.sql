-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    created_at TIMESTAMP,
    weight REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (ratio, weight, state) VALUES (18.21, 12.15, 'standard');
INSERT INTO layout_items (ratio, weight, state) VALUES (78.75, 97.87, 'stable');
INSERT INTO layout_items (ratio, weight, state) VALUES (68.73, 25.51, 'fallback');
