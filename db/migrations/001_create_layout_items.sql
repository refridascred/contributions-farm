-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    label TEXT,
    weight REAL,
    ratio REAL,
    state TEXT NOT NULL DEFAULT 'new'
);

CREATE INDEX IF NOT EXISTS idx_layout_items_ratio ON layout_items (ratio);

INSERT INTO layout_items (label, weight, ratio, state) VALUES ('standard', 85.49, 41.74, 'fallback');
INSERT INTO layout_items (label, weight, ratio, state) VALUES ('standard', 74.01, 27.95, 'fallback');
