-- Create the layout_items table.
CREATE TABLE IF NOT EXISTS layout_items (
    id INTEGER PRIMARY KEY,
    ratio REAL,
    weight REAL,
    count INTEGER NOT NULL DEFAULT 0,
    state TEXT NOT NULL DEFAULT 'new',
    created_at TIMESTAMP
);

CREATE INDEX IF NOT EXISTS idx_layout_items_created_at ON layout_items (created_at);

INSERT INTO layout_items (ratio, weight, count, state) VALUES (70.25, 78.02, 71, 'edge');
INSERT INTO layout_items (ratio, weight, count, state) VALUES (6.63, 93.73, 90, 'fallback');
INSERT INTO layout_items (ratio, weight, count, state) VALUES (74.62, 76.87, 71, 'eu-west');
